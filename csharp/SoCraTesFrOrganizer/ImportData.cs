using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;

namespace SoCraTesFrOrganizer
{
    public class ImportData
    {
        public List<string> ReadFile(string filePath)
        {
            List<string> fileContents;
            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    fileContents = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if(string.IsNullOrEmpty(line) || !line.Contains(";"))
                            throw new InvalidDataSourceException("invalid file!");
                        fileContents.Add(line);
                    }
                }
            }
            catch
            {
                throw new InvalidDataSourceException("invalid file!");
            }
            return fileContents;
        }

        public List<Check> MapToCheckIn(List<string> fileContents)
        {
            List<Check> checkIns = fileContents.Select(GetCheckIn).ToList();

            return checkIns;
        }

        private Check GetCheckIn(string line)
        {
            return Check.Of(line.Split(';')[1]);
        }

        private Check GetCheckOut(string line)
        {
            return Check.Of(line.Split(';')[2]);
        }

        private TypeRoom GetTypeRoom(string line)
        {
            TypeRoom typeRoom;
            Enum.TryParse(line.Split(';')[3], true, out typeRoom);
            return typeRoom;
        }

        public List<Participant> MapToParticipant(List<string> fileContents)
        {
            List<Participant> participants = fileContents.Select(Selector).ToList();

            return participants;
        }

        private Participant Selector(string line)
        {
            Check CheckIn = GetCheckIn(line);
            Check CheckOut = GetCheckOut(line);
            TypeRoom typeRoom = GetTypeRoom(line);
            return new Participant(typeRoom, CheckIn, CheckOut, null, null);
        }
    }
}
