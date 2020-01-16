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
        public List<string> ReadFile()
        {
            List<string> fileContents;
            try
            {
                using (var reader = new StreamReader(@""))
                {
                    fileContents = new List<string>();
                    while (Equals(!reader.EndOfStream))
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


        public List<CheckIn> MapToCheckIn(List<string> fileContents)
        {
            List<CheckIn> checkIns = fileContents.Select(line => CheckIn.Of(line.Split(';')[1])).ToList();

            return checkIns;
        }
    }
}
