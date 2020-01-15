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
        /*[Test]
        public void ReadCheckinFile()
        {
            MealsCountColdMeals mealsCountColdMeals = new MealsCountColdMeals(new FileStream("",FileMode.Create));
            Assert.IsNotNull(mealsCountColdMeals);
        }*/

        [Test]
        public void WithOneDateValid()
        {
            List<DateTime> datetime = new List<DateTime>()
            {
                new DateTime(2020, 10, 29, 23, 00, 00),
            };
            MealsCountColdMeals mealsCountColdMeals = new MealsCountColdMeals(datetime);
            var nb = mealsCountColdMeals.Count();
            
            Assert.AreEqual(1,nb);
        }

        [Test]
        public void WithTwoDateValid()
        {
            List<DateTime> datetime = new List<DateTime>()
            {
                new DateTime(2020, 10, 29, 23, 00, 00),
                new DateTime(2020, 10, 29, 22, 00, 00),
            };
            MealsCountColdMeals mealsCountColdMeals = new MealsCountColdMeals(datetime);
            var nb = mealsCountColdMeals.Count();

            Assert.AreEqual(2, nb);
        }

        [Test]
        public void WithThreeDateReturn2()
        {
            List<DateTime> datetime = new List<DateTime>()
            {
                new DateTime(2020, 10, 29, 23, 00, 00),
                new DateTime(2020, 10, 29, 22, 00, 00),
                new DateTime(2020, 10, 29, 16, 00, 00),
            };
            MealsCountColdMeals mealsCountColdMeals = new MealsCountColdMeals(datetime);
            var nb = mealsCountColdMeals.Count();

            Assert.AreEqual(2, nb);
        }

        [Test]
        public void WithFourDateReturn1()
        {
            List<DateTime> datetime = new List<DateTime>()
            {
                new DateTime(2020, 10, 29, 23, 00, 00),
                new DateTime(2020, 10, 29, 17, 00, 00),
                new DateTime(2020, 10, 29, 18, 00, 00),
                new DateTime(2020, 10, 29, 16, 00, 00),
            };
            MealsCountColdMeals mealsCountColdMeals = new MealsCountColdMeals(datetime);
            var nb = mealsCountColdMeals.Count();

            Assert.AreEqual(1, nb);
        }

        [Test]
        public void DifferentDatesDayReturn1()
        {
            List<DateTime> datetime = new List<DateTime>()
            {
                new DateTime(2020, 10, 29, 23, 00, 00),
                new DateTime(2020, 10, 30, 22, 00, 00)
            };
            MealsCountColdMeals mealsCountColdMeals = new MealsCountColdMeals(datetime);
            var nb = mealsCountColdMeals.Count();

            Assert.AreEqual(1, nb);
        }

        [Test]
        public void DifferentDatesDayReturn2()
        {
            List<DateTime> datetime = new List<DateTime>()
            {
                new DateTime(2020, 10, 29, 23, 00, 00),
                new DateTime(2020, 10, 30, 00, 00, 00)
            };
            MealsCountColdMeals mealsCountColdMeals = new MealsCountColdMeals(datetime);
            var nb = mealsCountColdMeals.Count();

            Assert.AreEqual(2, nb);
        }

        [Test]
        public void SameDayDifferentHoursReturn1()
        {
            List<DateTime> datetime = new List<DateTime>()
            {
                new DateTime(2020, 10, 29, 23, 00, 00),
                new DateTime(2020, 10, 29, 00, 00, 00)
            };
            MealsCountColdMeals mealsCountColdMeals = new MealsCountColdMeals(datetime);
            var nb = mealsCountColdMeals.Count();

            Assert.AreEqual(1, nb);
        }

        [Test]
        public void At21Hours()
        {
            List<DateTime> datetime = new List<DateTime>()
            {
                new DateTime(2020, 10, 29, 21, 00, 00),
            };
            MealsCountColdMeals mealsCountColdMeals = new MealsCountColdMeals(datetime);
            var nb = mealsCountColdMeals.Count();

            Assert.AreEqual(0, nb);
        }

        [Test]
        public void At1Hours()
        {
            List<DateTime> datetime = new List<DateTime>()
            {
                new DateTime(2020, 10, 30, 1, 00, 00),
            };
            MealsCountColdMeals mealsCountColdMeals = new MealsCountColdMeals(datetime);
            var nb = mealsCountColdMeals.Count();

            Assert.AreEqual(1, nb);
        }

        [Test]
        public void Nohours()
        {
            List<DateTime> datetime = new List<DateTime>()
            {
                new DateTime(2020, 10, 29),
            };
            MealsCountColdMeals mealsCountColdMeals = new MealsCountColdMeals(datetime);
            var nb = mealsCountColdMeals.Count();

            Assert.AreEqual(0, nb);
        }
    }
}
