using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoCraTesFrOrganizer
{
    public class CheckIn
    {
        public static CheckIn Of(string checkInDate)
        {
            DateTime result;
            DateTime.TryParse(checkInDate, out result);
            return new CheckIn(result);
        }

        private DateTime CheckInDate;

        private CheckIn(DateTime checkInDate)
        {
            CheckInDate = checkInDate;
        }

        public bool IsInBetweenDate(DateTime StartDate, DateTime EndDate)
        {
            return CheckInDate > StartDate && CheckInDate <= EndDate;
        }
    }
}
