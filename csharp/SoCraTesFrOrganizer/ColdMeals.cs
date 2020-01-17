using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace SoCraTesFrOrganizer
{
    public class ColdMeals
    {
        private readonly Range ColdMealsRange;

        public ColdMeals(DateTime startColdMeals, DateTime endColdMeals)
        {
            ColdMealsRange = Range.Of(startColdMeals, endColdMeals);
        }

        public int Count(List<CheckIn> CheckInDates)
        {
            return CheckInDates.Count(e=> e.IsBetweenDate(ColdMealsRange.StartColdMeals, ColdMealsRange.EndColdMeals));
        }
    }
}