using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SoCraTesFrOrganizer.Test.API
{
    [TestFixture]
    public class MealsTest
    {
        private readonly DateTime StartColdMeals = new DateTime(2020, 10, 29, 21, 00, 00);
        private readonly DateTime EndColdMeals = new DateTime(2020, 10, 30, 01, 00, 00);

        private readonly DateTime StartHotdMeals = new DateTime(2020, 10, 29, 21, 00, 00);
        private readonly DateTime EndHotMeals = new DateTime(2020, 10, 29, 22, 00, 00);

        private Meals _coldMeals;
        private Meals _hotMeals;

        [SetUp]
        public void SetUp()
        {
            _coldMeals = new Meals(StartColdMeals, EndColdMeals, true);
            _hotMeals = new Meals(StartHotdMeals, EndHotMeals, false);
        }

        #region COLD MEALS

        [Test]
        public void WithOneDateValid()
        {
            List<Booking> CheckIn = new List<Booking>()
            {
                Booking.Of(TypeRoom.NoAccommodation, Check.Of("29/10/2020 23:00"), null, Diet.Default)
            };
            var nb = _coldMeals.Count(CheckIn);

            Assert.AreEqual(1, nb);
        }

        [Test]
        public void WithTwoDateValid()
        {
            List<Booking> bookings = new List<Booking>()
            {
                Booking.Of(TypeRoom.NoAccommodation, Check.Of("29/10/2020 23:00"), null, Diet.Default),
                Booking.Of(TypeRoom.NoAccommodation, Check.Of("29/10/2020 22:00"), null, Diet.Default)
            };
            var nb = _coldMeals.Count(bookings);

            Assert.AreEqual(2, nb);
        }

        [Test]
        public void WithThreeDateReturn2()
        {
            List<Booking> bookings = new List<Booking>()
            {
                Booking.Of(TypeRoom.NoAccommodation, Check.Of("29/10/2020 23:00"), null, Diet.Default),
                Booking.Of(TypeRoom.NoAccommodation, Check.Of("29/10/2020 22:00"), null, Diet.Default),
                Booking.Of(TypeRoom.NoAccommodation, Check.Of("29/10/2020 16:00"), null, Diet.Default)
            };
            var nb = _coldMeals.Count(bookings);

            Assert.AreEqual(2, nb);
        }

        [Test]
        public void WithFourDateReturn1()
        {
            List<Booking> bookings = new List<Booking>()
            {
                Booking.Of(TypeRoom.NoAccommodation, Check.Of("29/10/2020 23:00"), null, Diet.Default),
                Booking.Of(TypeRoom.NoAccommodation, Check.Of("29/10/2020 17:00"), null, Diet.Default),
                Booking.Of(TypeRoom.NoAccommodation, Check.Of("29/10/2020 18:00"), null, Diet.Default),
                Booking.Of(TypeRoom.NoAccommodation, Check.Of("29/10/2020 16:00"), null, Diet.Default)
            };
            var nb = _coldMeals.Count(bookings);

            Assert.AreEqual(1, nb);
        }

        [Test]
        public void DifferentDatesDayReturn1()
        {
            List<Booking> bookings = new List<Booking>()
            {
                Booking.Of(TypeRoom.NoAccommodation, Check.Of("29/10/2020 23:00"), null, Diet.Default),
                Booking.Of(TypeRoom.NoAccommodation, Check.Of("30/10/2020 22:00"), null, Diet.Default)
            };
            var nb = _coldMeals.Count(bookings);

            Assert.AreEqual(1, nb);
        }

        [Test]
        public void DifferentDatesDayReturn2()
        {
            List<Booking> bookings = new List<Booking>()
            {
                Booking.Of(TypeRoom.NoAccommodation, Check.Of("29/10/2020 23:00"), null, Diet.Default),
                Booking.Of(TypeRoom.NoAccommodation, Check.Of("30/10/2020 00:00"), null, Diet.Default)
            };
            var nb = _coldMeals.Count(bookings);

            Assert.AreEqual(2, nb);
        }

        [Test]
        public void SameDayDifferentHoursReturn1()
        {
            List<Booking> bookings = new List<Booking>()
            {
                Booking.Of(TypeRoom.NoAccommodation, Check.Of("30/10/2020 01:00"), null, Diet.Default)
            };
            var nb = _coldMeals.Count(bookings);

            Assert.AreEqual(1, nb);
        }

        [Test]
        public void At21Hours()
        {
            List<Booking> bookings = new List<Booking>()
            {
                Booking.Of(TypeRoom.NoAccommodation, Check.Of("29/10/2020 21:00"), null, Diet.Default)
            };
            var nb = _coldMeals.Count(bookings);

            Assert.AreEqual(0, nb);
        }

        [Test]
        public void At1Hours()
        {
            List<Booking> bookings = new List<Booking>()
            {
                Booking.Of(TypeRoom.NoAccommodation, Check.Of("30/10/2020 01:00"), null, Diet.Default)
            };
            var nb = _coldMeals.Count(bookings);

            Assert.AreEqual(1, nb);
        }

        [Test]
        public void InvalidDate()
        {
            List<Booking> bookings = new List<Booking>()
            {
                Booking.Of(TypeRoom.NoAccommodation, Check.Of("29/10/2020"), null, Diet.Default),
                Booking.Of(TypeRoom.NoAccommodation, Check.Of("29/10/2020"), null, Diet.Default),
            };
            var nb = _coldMeals.Count(bookings);

            Assert.AreEqual(0, nb);
        }

        #endregion

        #region HOT MEALS

        [Test]
        public void CountHotMealsWithTwoDateValid()
        {
            List<Booking> bookings = new List<Booking>()
            {
                Booking.Of(TypeRoom.NoAccommodation, Check.Of("29/10/2020 19:00"), Check.Of("01/11/2020 19:00"), Diet.Default),
                Booking.Of(TypeRoom.NoAccommodation, Check.Of("29/10/2020 21:00"), Check.Of("01/11/2020 19:00"), Diet.Default)
            };
            var meals = new Meals(new DateTime(2020, 10, 29, 21, 00, 00), new DateTime(2020, 10, 29, 22, 00, 00), false);
            var nb = _hotMeals.Count(bookings);

            Assert.AreEqual(2, nb);
        }

        [Test]
        public void CountHotMealsWithTwoDateNotValid()
        {
            List<Booking> bookings = new List<Booking>()
            {
                Booking.Of(TypeRoom.NoAccommodation, Check.Of("30/10/2020 19:00"), Check.Of("01/11/2020 19:00"), Diet.Default),
                Booking.Of(TypeRoom.NoAccommodation, Check.Of("29/10/2020 22:00"), Check.Of("01/11/2020 19:00"), Diet.Default)
            };
            var meals = new Meals(new DateTime(2020, 10, 29, 21, 00, 00), new DateTime(2020, 10, 29, 22, 00, 00), false);
            var nb = _hotMeals.Count(bookings);

            Assert.AreEqual(0, nb);
        }

        #endregion
    }
}
