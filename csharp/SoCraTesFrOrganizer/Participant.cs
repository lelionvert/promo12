using System;

namespace SoCraTesFrOrganizer
{
    public class Participant
    {
        private readonly TypeRoom _typeRoom;

        public Participant(TypeRoom typeRoom)
        {
            _typeRoom = typeRoom;
        }

        public int CalculatePrice()
        {
            return (int)_typeRoom;
        }
    }
}