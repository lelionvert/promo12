using System;

namespace SoCraTesFrOrganizer
{
    public class Booking
    {
        private readonly TypeRoom _typeRoom;
        private readonly Check _checkIn;
        private readonly Check _checkOut;

        public Booking(TypeRoom typeRoom, Check checkIn, Check checkOut)
        {
            _typeRoom = typeRoom;
            _checkIn = checkIn;
            _checkOut = checkOut;
        }

        public int CalculatePrice(Meals mealIn, Meals mealOut)
        {
            int price = (int) _typeRoom;
            if (mealIn != null) price -= mealIn.isNotParticipeMeal(_checkIn);
            if (mealOut != null) price -= mealOut.isNotParticipeMeal(_checkOut);
            return price;
        }
    }
}