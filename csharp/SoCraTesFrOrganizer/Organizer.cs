using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace SoCraTesFrOrganizer.Test
{
    public class Organizer
    {
        private readonly IImportData _data;
        private List<Booking> _bookingsList;
        private List<Meals> _MealsList;

        public Organizer(IImportData data)
        {
            _data = data;
        }

        public void InitData(string fileInput)
        {
            List<string> fileContent = _data.ReadFile(fileInput);
            _bookingsList = _data.MapToBooking(fileContent);
        }

        public int CountDiet(Diet diet)
        {
            return _MealsList.Sum(meals => CountMealDiet(diet, meals));
        }

        private int CountMealDiet(Diet diet, Meals meals)
        {
            return _bookingsList.Count(e => meals.HasParticipateToMeal(e));
        }
    }
}