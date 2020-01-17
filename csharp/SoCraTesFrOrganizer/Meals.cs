using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace SoCraTesFrOrganizer
{
    public class Meals
    {
        private readonly Range ColdMealsRange;
        private static int PRICEMEAL = 40;

        public Meals(DateTime startColdMeals, DateTime endColdMeals)
        {
            ColdMealsRange = Range.Of(startColdMeals, endColdMeals);
        }

        public int isNotParticipeMeal(Check check)
        {
            return check.IsBetweenDate(ColdMealsRange.StartColdMeals, ColdMealsRange.EndColdMeals) ? 0 : PRICEMEAL;
        }

        public int Count(List<Check> CheckInDates)
        {
            return CheckInDates.Count(e=> e.IsBetweenDate(ColdMealsRange.StartColdMeals, ColdMealsRange.EndColdMeals));
        }
    }
}