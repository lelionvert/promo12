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
            if (_typeRoom == TypeRoom.Single)
            {
                return 610;
            }

            return 510;
        }
    }
}