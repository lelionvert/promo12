using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace SoCraTesFrOrganizer.Test
{
    [TestFixture]
    public class OrganizerTest
    {
        private string _pathFile = @"C:\Users\lenovo 3\source\repos\SoCraTesFrOrganizer\csharp\SoCraTesFrOrganizer\";
        private Organizer _organizer;
        private Mock<IImportData> _data;

        [SetUp]
        public void SetUp()
        {
            _data = new Mock<IImportData>();
            List<Booking> listBooking = new List<Booking>()
            {
                new Booking(TypeRoom.Single, Check.Of("29/10/2020 14:32"), Check.Of("01/11/2020 14:32"), Diet.Vegetarian),
                new Booking(TypeRoom.Twin, Check.Of("29/10/2020 17:00"), Check.Of("31/10/2020 17:55"), Diet.Vegetarian),
                new Booking(TypeRoom.Twin, Check.Of("30/10/2020 08:32"), Check.Of("01/11/2020 14:32"), Diet.Vegetarian),
                new Booking(TypeRoom.Single, Check.Of("30/10/2020 08:32"), Check.Of("31/10/2020 17:55"), Diet.Vegetarian),
                new Booking(TypeRoom.Single, Check.Of("30/10/2020 08:32"), Check.Of("31/10/2020 17:55"), Diet.Vegetarian),
                new Booking(TypeRoom.Single, Check.Of("29/10/2020 14:32"), Check.Of("01/11/2020 14:32"), Diet.Vegan),
                new Booking(TypeRoom.Twin, Check.Of("29/10/2020 17:00"), Check.Of("31/10/2020 17:55"), Diet.Vegan),
                new Booking(TypeRoom.Twin, Check.Of("30/10/2020 08:32"), Check.Of("01/11/2020 14:32"), Diet.Vegan),
                new Booking(TypeRoom.Single, Check.Of("30/10/2020 08:32"), Check.Of("31/10/2020 17:55"), Diet.Vegan),
                new Booking(TypeRoom.Single, Check.Of("30/10/2020 08:32"), Check.Of("31/10/2020 17:55"), Diet.Vegan),
                new Booking(TypeRoom.Single, Check.Of("29/10/2020 14:32"), Check.Of("01/11/2020 14:32"), Diet.Pescatarian),
                new Booking(TypeRoom.Twin, Check.Of("29/10/2020 17:00"), Check.Of("31/10/2020 17:55"), Diet.Pescatarian),
                new Booking(TypeRoom.Twin, Check.Of("30/10/2020 08:32"), Check.Of("01/11/2020 14:32"), Diet.Pescatarian),
                new Booking(TypeRoom.Single, Check.Of("30/10/2020 08:32"), Check.Of("31/10/2020 17:55"), Diet.Pescatarian),
                new Booking(TypeRoom.Single, Check.Of("30/10/2020 08:32"), Check.Of("31/10/2020 17:55"), Diet.Pescatarian),
                new Booking(TypeRoom.Single, Check.Of("29/10/2020 14:32"), Check.Of("01/11/2020 14:32"), Diet.Default),
                new Booking(TypeRoom.Twin, Check.Of("29/10/2020 17:00"), Check.Of("31/10/2020 17:55"), Diet.Default),
                new Booking(TypeRoom.Twin, Check.Of("30/10/2020 08:32"), Check.Of("01/11/2020 14:32"), Diet.Default),
                new Booking(TypeRoom.Single, Check.Of("30/10/2020 08:32"), Check.Of("31/10/2020 17:55"), Diet.Default),
                new Booking(TypeRoom.Single, Check.Of("30/10/2020 08:32"), Check.Of("31/10/2020 17:55"), Diet.Default),

            };
            
            _data.Setup(e => e.ReadFile(Path.Combine(_pathFile, "ChoicesWithDietsSmall.csv")))
                .Returns(new List<string>());
            _data.Setup(e => e.MapToBooking(new List<string>()))
                .Returns(listBooking);
            _organizer = new Organizer(_data.Object);
            _organizer.InitData(Path.Combine(_pathFile, "ChoicesWithDietsSmall.csv"));
        }

        [Test]
        public void TotalVegan()
        {
            int totalVegan = _organizer.CountDiet(Diet.Vegan);
            Assert.AreEqual(23, totalVegan);
        }

        [Test]
        public void TotalVegetarian()
        {
            int totalVegetarian = _organizer.CountDiet(Diet.Vegetarian);
            Assert.AreEqual(23, totalVegetarian);
        }

        [Test]
        public void TotalPescatarian()
        {
            int totalPescatarian = _organizer.CountDiet(Diet.Pescatarian);
            Assert.AreEqual(23, totalPescatarian);
        }

        [Test]
        public void TotalDefault()
        {
            int totalDefault = _organizer.CountDiet(Diet.Default);
            Assert.AreEqual(23, totalDefault);
        }
    }
}
