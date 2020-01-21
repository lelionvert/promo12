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
    public class ColdMealsTest
    {
        private readonly DateTime StartColdMeals = new DateTime(2020, 10, 29, 21, 00, 00);
        private readonly DateTime EndColdMeals = new DateTime(2020, 10, 30, 1, 00, 00);

        [Test]
        public void WithOneDateValid()
        {
            List<Check> CheckIn = new List<Check>()
            {
                Check.Of("29/10/2020 23:00")
            };
            Meals meals = new Meals(StartColdMeals, EndColdMeals);
            var nb = meals.Count(CheckIn);
            
            Assert.AreEqual(1,nb);
        }

        [Test]
        public void WithTwoDateValid()
        {
            List<Check> datetime = new List<Check>()
            {
                Check.Of("29/10/2020 23:00"),
                Check.Of("29/10/2020 22:00")
            };
            Meals meals = new Meals(StartColdMeals, EndColdMeals);
            var nb = meals.Count(datetime);

            Assert.AreEqual(2, nb);
        }

        [Test]
        public void WithThreeDateReturn2()
        {
            List<Check> datetime = new List<Check>()
            {
                Check.Of("29/10/2020 23:00"),
                Check.Of("29/10/2020 22:00"),
                Check.Of("29/10/2020 16:00")
            };
            Meals meals = new Meals(StartColdMeals, EndColdMeals);
            var nb = meals.Count(datetime);

            Assert.AreEqual(2, nb);
        }

        [Test]
        public void WithFourDateReturn1()
        {
            List<Check> datetime = new List<Check>()
            {
                Check.Of("29/10/2020 23:00"),
                Check.Of("29/10/2020 17:00"),
                Check.Of("29/10/2020 18:00"),
                Check.Of("29/10/2020 16:00")
            };
            Meals meals = new Meals(StartColdMeals, EndColdMeals);
            var nb = meals.Count(datetime);

            Assert.AreEqual(1, nb);
        }

        [Test]
        public void DifferentDatesDayReturn1()
        {
            List<Check> datetime = new List<Check>()
            {
                Check.Of("29/10/2020 23:00"),
                Check.Of("30/10/2020 22:00")
            };
            Meals meals = new Meals(StartColdMeals, EndColdMeals);
            var nb = meals.Count(datetime);

            Assert.AreEqual(1, nb);
        }

        [Test]
        public void DifferentDatesDayReturn2()
        {
            List<Check> datetime = new List<Check>()
            {
                Check.Of("29/10/2020 23:00"),
                Check.Of("30/10/2020 00:00")
            };
            Meals meals = new Meals(StartColdMeals, EndColdMeals);
            var nb = meals.Count(datetime);

            Assert.AreEqual(2, nb);
        }

        [Test]
        public void SameDayDifferentHoursReturn1()
        {
            List<Check> datetime = new List<Check>()
            {
                Check.Of("29/10/2020 23:00"),
                Check.Of("29/10/2020 00:00")
            };
            Meals meals = new Meals(StartColdMeals, EndColdMeals);
            var nb = meals.Count(datetime);

            Assert.AreEqual(1, nb);
        }

        [Test]
        public void At21Hours()
        {
            List<Check> datetime = new List<Check>()
            {
                Check.Of("29/10/2020 21:00")
            };
            Meals meals = new Meals(StartColdMeals, EndColdMeals);
            var nb = meals.Count(datetime);

            Assert.AreEqual(0, nb);
        }

        [Test]
        public void At1Hours()
        {
            List<Check> datetime = new List<Check>()
            {
                Check.Of("30/10/2020 01:00")
            };
            Meals meals = new Meals(StartColdMeals, EndColdMeals);
            var nb = meals.Count(datetime);

            Assert.AreEqual(1, nb);
        }

        [Test]
        public void InvalidDate()
        {
            List<Check> datetime = new List<Check>()
            {
                Check.Of("29/10/2020")
            };
            Meals meals = new Meals(StartColdMeals, EndColdMeals);
            var nb = meals.Count(datetime);

            Assert.AreEqual(0, nb);
        }
    }
}
