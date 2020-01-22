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
        private readonly bool _isColdMeal;

        public int PRICEMEAL { get; } = 40;

        public Meals(DateTime startColdMeals, DateTime endColdMeals, bool isColdMeal = false)
        {
            _isColdMeal = isColdMeal;
            MealsRange = Range.Of(startColdMeals, endColdMeals);
        }

        public bool IsParticipate(Booking booking)
        {
            return booking.CheckIn.IsBefore(MealsRange.StartColdMeals) && booking.CheckOut.IsAfter(MealsRange.EndColdMeals);
        }

        public int Count(List<Booking> bookings)
        {
            if (_isColdMeal)
                return bookings.Count(e => e.CheckIn.IsAfter(MealsRange.StartColdMeals) && e.CheckIn.IsBefore(MealsRange.EndColdMeals));

            return bookings.Count(e=> e.CheckIn.IsBefore(MealsRange.StartColdMeals) && e.CheckOut.IsAfter(MealsRange.EndColdMeals));
        }
    }
}