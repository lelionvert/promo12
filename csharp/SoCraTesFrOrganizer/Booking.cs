using System;

namespace SoCraTesFrOrganizer
{
    public class Booking
    {
        private readonly TypeRoom _typeRoom;
        private readonly Check _checkIn;
        private readonly Check _checkOut;
        private readonly Diet _diet;

        public Booking(TypeRoom typeRoom, Check checkIn, Check checkOut, Diet diet)
        {
            _typeRoom = typeRoom;
            _checkIn = checkIn;
            _checkOut = checkOut;
            _diet = diet;
        }

        public Check CheckIn
        {
            get => _checkIn;
        }

        public Check CheckOut
        {
            get => _checkOut;
        }

        public int CalculatePrice(Meals mealIn, Meals mealOut)
        {
            int price = (int) _typeRoom;
            if (mealIn != null) price -= mealIn.IsNotParticipeMeal(_checkIn);
            if (mealOut != null) price -= mealOut.IsNotParticipeMeal(_checkOut);
            return price;
        }
    }
}