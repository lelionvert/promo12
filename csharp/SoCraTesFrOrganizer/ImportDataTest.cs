using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace SoCraTesFrOrganizer
{
    [TestFixture]
    public class ImportDataTest
    {
        private string pathFile = @"C:\Users\lenovo 3\source\repos\SoCraTesFrOrganizer\csharp\SoCraTesFrOrganizer\";

        [Test]
        public void ReadFileWithValidData()
        {
            ImportData data = new ImportData();
            List<string> result = data.ReadFile(Path.Combine(pathFile, "Checkins.csv"));
            Assert.IsTrue(result?.Count > 0);
        }

        [Test]
        public void ReadFileNotExit()
        {
            ImportData data = new ImportData();
            Assert.Catch<InvalidDataSourceException>(() => data.ReadFile(Path.Combine(pathFile, "CheckinsWrong.csv")));
        }

        [Test]
        public void ReadFileWithWrongData()
        {
            ImportData data = new ImportData();
            Assert.Catch<InvalidDataSourceException>(() => data.ReadFile(Path.Combine(pathFile, "CheckinsWrongData.csv")));
        }

        [Test]
        public void MapDataToCheckin()
        {
            ImportData data = new ImportData();
            List<string> fileContents = data.ReadFile(Path.Combine(pathFile, "Checkins.csv"));
            List<CheckIn> result = data.MapToCheckIn(fileContents);

            Assert.IsTrue(result?.Count > 0);
        }
    }
}

