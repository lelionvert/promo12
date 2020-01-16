using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace SoCraTesFrOrganizer
{
    public class ColdMeals
    {
        private List<CheckIn> CheckInDates;
        private readonly Range ColdMealsRange;

        public ColdMeals(List<CheckIn> checkInDates, DateTime startColdMeals, DateTime endColdMeals)
        {
            this.CheckInDates = checkInDates;
            ColdMealsRange = Range.Of(startColdMeals, endColdMeals);
        }

        public int Count()
        {
            return CheckInDates.Count(e=> e.IsInBetweenDate(ColdMealsRange.StartColdMeals, ColdMealsRange.EndColdMeals));
        }
    }
}