using System;

namespace SoCraTesFrOrganizer
{
    public class Range
    {
        public static Range Of(DateTime startColdMeals, DateTime endColdMeals)
        {
            if (startColdMeals >= endColdMeals)
                throw new ArgumentException();
            return new Range(startColdMeals, endColdMeals);
        }

        private DateTime _startColdMeals;
        private DateTime _endColdMeals;

        private Range(DateTime startColdMeals, DateTime endColdMeals)
        {
            _startColdMeals = startColdMeals;
            _endColdMeals = endColdMeals;
        }

        public DateTime StartColdMeals
        {
            get => _startColdMeals;
        }

        public DateTime EndColdMeals
        {
            get => _endColdMeals;
        }
    }
}