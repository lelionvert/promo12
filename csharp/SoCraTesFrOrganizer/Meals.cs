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

        public bool isParticipeMeal(CheckIn checkIn)
        {
            return checkIn.IsBetweenDate(ColdMealsRange.StartColdMeals, ColdMealsRange.EndColdMeals);
        }

        public int Count(List<CheckIn> CheckInDates)
        {
            return CheckInDates.Count(e=> e.IsBetweenDate(ColdMealsRange.StartColdMeals, ColdMealsRange.EndColdMeals));
        }
    }
}