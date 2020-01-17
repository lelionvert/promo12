using System;

namespace SoCraTesFrOrganizer
{
    public class Participant
    {
        private readonly TypeRoom _typeRoom;
        private readonly CheckIn _checkIn;
        private readonly Meals _meal;

        public Participant(TypeRoom typeRoom, CheckIn checkIn, Meals meal)
        {
            _typeRoom = typeRoom;
            _checkIn = checkIn;
            _meal = meal;
        }

        public int CalculatePrice()
        {
            int price = (int) _typeRoom;
            if (_meal != null && !_meal.isParticipeMeal(_checkIn))
                return 200;
            return price;
        }
    }
}