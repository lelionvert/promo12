using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace SoCraTesFrOrganizer
{
    public class MealsCountColdMeals
    {
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
            return dates.Count(e=> (e.Hour > 21 && e.DayOfWeek == DayOfWeek.Thursday) || (e.Hour <= 1 && e.DayOfWeek == DayOfWeek.Friday));
        }
    }
}