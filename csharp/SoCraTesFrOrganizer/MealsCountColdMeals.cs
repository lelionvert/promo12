using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace SoCraTesFrOrganizer
{
    public class MealsCountColdMeals
    {
        private FileStream l_File;
        private List<DateTime> dates;

        public MealsCountColdMeals(FileStream l_File)
        {
            this.l_File = l_File;
        }

        public MealsCountColdMeals(List<DateTime> l_Datetime)
        {
            this.dates = l_Datetime;
        }

        internal int count()
        {
            return dates.Count(e=> (e.Hour > 21 && e.DayOfWeek == DayOfWeek.Thursday) || (e.Hour < 1 && e.DayOfWeek == DayOfWeek.Friday));
        }
    }
}