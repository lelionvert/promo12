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
            MealsCountColdMeals l_MealsCountColdMeals = new MealsCountColdMeals(new FileStream("",FileMode.Create));
            Assert.IsNotNull(l_MealsCountColdMeals);
        }*/

        [Test]
        public void CountColdMealWithOneDate()
        {
            List<DateTime> l_Datetime = new List<DateTime>()
            {
                new DateTime(2020, 10, 29, 23, 00, 00),
            };
            MealsCountColdMeals l_MealsCountColdMeals = new MealsCountColdMeals(l_Datetime);
            var nb = l_MealsCountColdMeals.count();
            
            Assert.AreEqual(1,nb);
        }

        [Test]
        public void CountColdMealWithTwoDate()
        {
            List<DateTime> l_Datetime = new List<DateTime>()
            {
                new DateTime(2020, 10, 29, 23, 00, 00),
                new DateTime(2020, 10, 29, 22, 00, 00),
            };
            MealsCountColdMeals l_MealsCountColdMeals = new MealsCountColdMeals(l_Datetime);
            var nb = l_MealsCountColdMeals.count();

            Assert.AreEqual(2, nb);
        }
    }
}
