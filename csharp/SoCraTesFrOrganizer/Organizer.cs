using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SoCraTesFrOrganizer.Communication;

namespace SoCraTesFrOrganizer
{
    public class Organizer
    {
        private readonly IReaderData _data;
        private List<Booking> _bookingsList;
        private List<Meals> _MealsList;

        public Organizer(IReaderData data)
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
            return _bookingsList.Count(meals.IsParticipate);
        }

        public List<int> CalculatePrice(Meals mealIn, Meals mealOut)
        {
            return _bookingsList.Select(booking => CalculatePrice(mealIn, mealOut, booking)).ToList();
        }

        private int CalculatePrice(Meals mealIn, Meals mealOut, Booking booking)
        {
            int price = (int) booking.Room;
            if (mealIn != null) price -= mealIn.IsParticipate(booking) ? 0 :  mealIn.PRICEMEAL;
            if (mealOut != null) price -= mealOut.IsParticipate(booking) ? 0 : mealIn.PRICEMEAL;
            return price;
        }
    }
}