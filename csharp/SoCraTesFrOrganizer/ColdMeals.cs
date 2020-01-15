using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace SoCraTesFrOrganizer
{
    public class MealsCountColdMeals
    {
        private readonly DateTime dateStartColdMeals = new DateTime(2020, 10, 29, 21, 00, 00);
        private readonly DateTime dateEndColdMeals = new DateTime(2020, 10, 30, 21, 00, 00);
        private List<DateTime> dates;

        /*public MealsCountColdMeals(FileStream file)
        {
        }*/

        public MealsCountColdMeals(List<DateTime> datetime)
        {
            this.dates = datetime;
        }

        public int Count()
        {
            return dates.Count(e=> e > dateStartColdMeals || e <= dateEndColdMeals);
        }
    }
}