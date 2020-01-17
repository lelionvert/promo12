using System;

namespace SoCraTesFrOrganizer
{
    public class Participant
    {
        private readonly TypeRoom _typeRoom;
        private readonly Check _checkIn;
        private readonly Check _checkOut;
        private readonly Meals _mealIn;
        private readonly Meals _mealOut;
        private static int PriceMeal = 40;

        public Participant(TypeRoom typeRoom, Check checkIn, Check checkOut, Meals mealIn, Meals mealOut)
        {
            _typeRoom = typeRoom;
            _checkIn = checkIn;
            _checkOut = checkOut;
            _mealIn = mealIn;
            _mealOut = mealOut;
        }

        public int CalculatePrice()
        {
            int price = (int) _typeRoom;
            if (_mealIn != null && !_mealIn.isParticipeMeal(_checkIn)) price -= PriceMeal;
            if (_mealOut != null && !_mealOut.isParticipeMeal(_checkOut)) price -= PriceMeal;
            return price;
        }
    }
}