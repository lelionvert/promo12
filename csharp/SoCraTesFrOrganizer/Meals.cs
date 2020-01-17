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

        public Meals(DateTime startColdMeals, DateTime endColdMeals)
        {
            ColdMealsRange = Range.Of(startColdMeals, endColdMeals);
        }

        public bool isParticipeMeal(Check check)
        {
            return check.IsBetweenDate(ColdMealsRange.StartColdMeals, ColdMealsRange.EndColdMeals);
        }

        public int Count(List<Check> CheckInDates)
        {
            return CheckInDates.Count(e=> e.IsBetweenDate(ColdMealsRange.StartColdMeals, ColdMealsRange.EndColdMeals));
        }
    }
}