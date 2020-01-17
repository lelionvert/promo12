using System;

namespace SoCraTesFrOrganizer
{
    public class Participant
    {
        private readonly TypeRoom _typeRoom;
        private readonly Check _check;
        private readonly Meals _meal;
        private static int PriceMeal = 40;

        public Participant(TypeRoom typeRoom, Check check, Meals meal)
        {
            _typeRoom = typeRoom;
            _check = check;
            _meal = meal;
        }

        public int CalculatePrice()
        {
            int price = (int) _typeRoom;
            if (_meal != null && !_meal.isParticipeMeal(_check)) price -= PriceMeal;

            return price;
        }
    }
}