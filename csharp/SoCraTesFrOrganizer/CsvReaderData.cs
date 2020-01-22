using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using SoCraTesFrOrganizer.Communication;

namespace SoCraTesFrOrganizer
{
    public class CsvReaderData : IReaderData
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

        public List<Booking> ReadBooking(string filePath)
        {
            return MapToBooking(ReadFile(filePath));
        }

        public List<Booking> MapToBooking(List<string> fileContents)
        {
            return fileContents.Select(GetBooking).ToList();
        }

        private static Booking GetBooking(string line)
        {
            List<string> element = line.Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries).ToList();
            Check checkIn = GetCheckIn(element);
            Check checkOut = GetCheckOut(element);
            TypeRoom typeRoom = GetTypeRoom(element);
            Diet diet = GetDiet(element);

            return Booking.Of(typeRoom, checkIn, checkOut, diet);
        }

        private static Check GetCheckIn(List<string> line)
        {
            if (line.Count < 2)
                return null;

            return Check.Of(line[1]);
        }

        private static Check GetCheckOut(List<string> line)
        {
            if (line.Count < 3)
                return null;

            return Check.Of(line[2]);
        }

        private static TypeRoom GetTypeRoom(List<string> line)
        {
            if (line.Count < 4)
                return TypeRoom.NoAccommodation;

            Enum.TryParse(line[3], true, out TypeRoom typeRoom);
            return typeRoom;
        }

        private static Diet GetDiet(List<string> line)
        {
            if (line.Count < 5)
                return Diet.Default;

            Enum.TryParse(line[4], true, out Diet diet);
            return diet;
        }
    }
}
