using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SoCraTesFrOrganizer.Test.API
{
    [TestFixture]
    public class BookingTest
    {
        private Meals _mealOut = new Meals(new DateTime(2020, 11, 01, 14, 0, 0), new DateTime(2020, 11, 2, 0, 0, 0));
        private Meals _mealIn = new Meals(new DateTime(2020, 10, 29, 16, 0, 0), new DateTime(2020, 10, 30, 1, 0, 0));

        [Test]
        public void SingleRoom()
        {
            TypeRoom typeRoom = TypeRoom.Single;
            Booking booking = Booking.Of(typeRoom, null, null, Diet.Default);
            int price = 610;// = booking.CalculatePrice(null, null);
            Assert.AreEqual(610, price);
        }
    }
}
