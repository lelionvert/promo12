using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoCraTesFrOrganizer
{
    public class Check
    {
        public static Check Of(string checkInDate)
        {
            DateTime result;
            DateTime.TryParse(checkInDate, out result);
            return new Check(result);
        }

        private DateTime CheckInDate;

        private Check(DateTime checkInDate)
        {
            CheckInDate = checkInDate;
        }

        public bool IsBetweenDate(DateTime StartDate, DateTime EndDate)
        {
            return CheckInDate > StartDate && CheckInDate <= EndDate;
        }
    }
}
