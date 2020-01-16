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
        private ImportData Import;

        [SetUp]
        public void Init()
        {
            Import = new ImportData();
        }

        [Test]
        public void ReadFileWithValidData()
        {
            List<string> result = Import.ReadFile(Path.Combine(pathFile, "Checkins.csv"));
            Assert.IsTrue(result?.Count > 0);
        }

        [Test]
        public void ReadFileNotExit()
        {
            Assert.Catch<InvalidDataSourceException>(() => Import.ReadFile(Path.Combine(pathFile, "CheckinsWrong.csv")));
        }

        [Test]
        public void ReadFileWithWrongData()
        {
            Assert.Catch<InvalidDataSourceException>(() => Import.ReadFile(Path.Combine(pathFile, "CheckinsWrongData.csv")));
        }

        [Test]
        public void MapDataToCheckIn()
        {
            List<string> fileContents = Import.ReadFile(Path.Combine(pathFile, "Checkins.csv"));
            List<CheckIn> result = Import.MapToCheckIn(fileContents);

            Assert.IsTrue(result?.Count > 0);
        }
    }
}

