using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace SoCraTesFrOrganizer
{
    public class Meals
    {
        private readonly Range MealsRange;
        private static int PRICEMEAL = 40;

        public Meals(DateTime startColdMeals, DateTime endColdMeals)
        {
            MealsRange = Range.Of(startColdMeals, endColdMeals);
        }

        public int IsNotParticipeMeal(Check check)
        {
            return !IsParticipate(check) ? PRICEMEAL : 0;
        }

        private bool IsParticipate(Check check)
        {
            return check.IsBetweenDate(MealsRange.StartColdMeals, MealsRange.EndColdMeals);
        }

        public int Count(List<Check> CheckInDates)
        {
            return CheckInDates.Count(e=> e.IsBetweenDate(MealsRange.StartColdMeals, MealsRange.EndColdMeals));
        }

        public bool HasParticipateToMeal(Booking booking)
        {
            return IsBefore(booking.CheckIn) && IsAfter(booking.CheckOut) ? true : false;
        }

        private bool IsAfter(Check checkOut)
        {
            return checkOut.IsBefore(MealsRange.StartColdMeals, MealsRange.EndColdMeals);
        }

        private bool IsBefore(Check checkIn)
        {
            return checkIn.IsAfter(MealsRange.StartColdMeals, MealsRange.EndColdMeals);
        }
    }
}