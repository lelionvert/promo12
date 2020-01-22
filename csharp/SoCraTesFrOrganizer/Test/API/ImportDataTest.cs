using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace SoCraTesFrOrganizer.Test.API
{
    [TestFixture]
    public class ImportDataTest
    {
        private string pathFile = @"C:\Users\lenovo 3\source\repos\SoCraTesFrOrganizer\csharp\SoCraTesFrOrganizer\";
        private CsvReaderData _csvReader;

        [SetUp]
        public void Init()
        {
            _csvReader = new CsvReaderData();
        }

        [Test]
        public void ReadFileWithValidData()
        {
            List<string> result = _csvReader.ReadFile(Path.Combine(pathFile, "Checkins.csv"));
            Assert.IsTrue(result?.Count > 0);
        }

        [Test]
        public void ReadFileNotExit()
        {
            Assert.Catch<InvalidDataSourceException>(() => _csvReader.ReadFile(Path.Combine(pathFile, "CheckinsWrong.csv")));
        }

        [Test]
        public void ReadFileWithWrongData()
        {
            Assert.Catch<InvalidDataSourceException>(() => _csvReader.ReadFile(Path.Combine(pathFile, "CheckinsWrongData.csv")));
        }

        [Test]
        public void MapDataToBookingParticipants()
        {
            List<Booking> participants = _csvReader.ReadBooking(Path.Combine(pathFile, "Participants.csv"));

            Assert.IsTrue(participants?.Count > 0);
        }

        [Test]
        public void MapDataToBookingCheckIns()
        {
            List<Booking> participants = _csvReader.ReadBooking(Path.Combine(pathFile, "Checkins.csv"));

            Assert.IsTrue(participants?.Count > 0);
        }

        [Test]
        public void MapDataToBookingChoices()
        {
            List<Booking> participants = _csvReader.ReadBooking(Path.Combine(pathFile, "Choices.csv"));

            Assert.IsTrue(participants?.Count > 0);
        }

        [Test]
        public void MapDataToBookingChoicesWithDiets()
        {
            List<Booking> participants = _csvReader.ReadBooking(Path.Combine(pathFile, "ChoicesWithDiets.csv"));

            Assert.IsTrue(participants?.Count > 0);
        }
    }
}

