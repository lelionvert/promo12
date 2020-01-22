using System;

namespace SoCraTesFrOrganizer
{
    public class Booking
    {
        private readonly TypeRoom _typeRoom;
        private readonly Check _checkIn;
        private readonly Check _checkOut;
        private readonly Diet _diet;

        public static Booking Of(TypeRoom typeRoom, Check checkIn, Check checkOut, Diet diet)
        {
            return new Booking(typeRoom, checkIn, checkOut, diet);
        }

        private Booking(TypeRoom typeRoom, Check checkIn, Check checkOut, Diet diet)
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

        public TypeRoom Room
        {
            get => _typeRoom;
        }
    }
}