using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace SoCraTesFrOrganizer
{
    [TestFixture]
    public class MealsCountColdMealsTest
    {
        private readonly DateTime StartColdMeals = new DateTime(2020, 10, 29, 21, 00, 00);
        private readonly DateTime EndColdMeals = new DateTime(2020, 10, 30, 1, 00, 00);

        [Test]
        public void WithOneDateValid()
        {
            List<CheckIn> CheckIn = new List<CheckIn>()
            {
                SoCraTesFrOrganizer.CheckIn.Of("29/10/2020 23:00")
            };
            ColdMeals coldMeals = new ColdMeals(StartColdMeals, EndColdMeals);
            var nb = coldMeals.Count(CheckIn);
            
            Assert.AreEqual(1,nb);
        }

        [Test]
        public void WithTwoDateValid()
        {
            List<CheckIn> datetime = new List<CheckIn>()
            {
                CheckIn.Of("29/10/2020 23:00"),
                CheckIn.Of("29/10/2020 22:00")
            };
            ColdMeals coldMeals = new ColdMeals(StartColdMeals, EndColdMeals);
            var nb = coldMeals.Count(datetime);

            Assert.AreEqual(2, nb);
        }

        [Test]
        public void WithThreeDateReturn2()
        {
            List<CheckIn> datetime = new List<CheckIn>()
            {
                CheckIn.Of("29/10/2020 23:00"),
                CheckIn.Of("29/10/2020 22:00"),
                CheckIn.Of("29/10/2020 16:00")
            };
            ColdMeals coldMeals = new ColdMeals(StartColdMeals, EndColdMeals);
            var nb = coldMeals.Count(datetime);

            Assert.AreEqual(2, nb);
        }

        [Test]
        public void WithFourDateReturn1()
        {
            List<CheckIn> datetime = new List<CheckIn>()
            {
                CheckIn.Of("29/10/2020 23:00"),
                CheckIn.Of("29/10/2020 17:00"),
                CheckIn.Of("29/10/2020 18:00"),
                CheckIn.Of("29/10/2020 16:00")
            };
            ColdMeals coldMeals = new ColdMeals(StartColdMeals, EndColdMeals);
            var nb = coldMeals.Count(datetime);

            Assert.AreEqual(1, nb);
        }

        [Test]
        public void DifferentDatesDayReturn1()
        {
            List<CheckIn> datetime = new List<CheckIn>()
            {
                CheckIn.Of("29/10/2020 23:00"),
                CheckIn.Of("30/10/2020 22:00")
            };
            ColdMeals coldMeals = new ColdMeals(StartColdMeals, EndColdMeals);
            var nb = coldMeals.Count(datetime);

            Assert.AreEqual(1, nb);
        }

        [Test]
        public void DifferentDatesDayReturn2()
        {
            List<CheckIn> datetime = new List<CheckIn>()
            {
                CheckIn.Of("29/10/2020 23:00"),
                CheckIn.Of("30/10/2020 00:00")
            };
            ColdMeals coldMeals = new ColdMeals(StartColdMeals, EndColdMeals);
            var nb = coldMeals.Count(datetime);

            Assert.AreEqual(2, nb);
        }

        [Test]
        public void SameDayDifferentHoursReturn1()
        {
            List<CheckIn> datetime = new List<CheckIn>()
            {
                CheckIn.Of("29/10/2020 23:00"),
                CheckIn.Of("29/10/2020 00:00")
            };
            ColdMeals coldMeals = new ColdMeals(StartColdMeals, EndColdMeals);
            var nb = coldMeals.Count(datetime);

            Assert.AreEqual(1, nb);
        }

        [Test]
        public void At21Hours()
        {
            List<CheckIn> datetime = new List<CheckIn>()
            {
                CheckIn.Of("29/10/2020 21:00")
            };
            ColdMeals coldMeals = new ColdMeals(StartColdMeals, EndColdMeals);
            var nb = coldMeals.Count(datetime);

            Assert.AreEqual(0, nb);
        }

        [Test]
        public void At1Hours()
        {
            List<CheckIn> datetime = new List<CheckIn>()
            {
                CheckIn.Of("30/10/2020 01:00")
            };
            ColdMeals coldMeals = new ColdMeals(StartColdMeals, EndColdMeals);
            var nb = coldMeals.Count(datetime);

            Assert.AreEqual(1, nb);
        }

        [Test]
        public void InvalidDate()
        {
            List<CheckIn> datetime = new List<CheckIn>()
            {
                CheckIn.Of("29/10/2020")
            };
            ColdMeals coldMeals = new ColdMeals(StartColdMeals, EndColdMeals);
            var nb = coldMeals.Count(datetime);

            Assert.AreEqual(0, nb);
        }
    }
}
