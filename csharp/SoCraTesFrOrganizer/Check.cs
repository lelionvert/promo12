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

        private DateTime CheckDate;

        private Check(DateTime checkDate)
        {
            CheckDate = checkDate;
        }

        public bool IsBefore(DateTime StartMealsDateTime)
        {
            return CheckDate <= StartMealsDateTime;
        }

        public bool IsAfter(DateTime EndMealsDateTime)
        {
            return EndMealsDateTime < CheckDate;
        }
    }
}
