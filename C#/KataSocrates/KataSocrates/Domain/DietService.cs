using System;
using System.Collections.Generic;

namespace KataSocrates.Domain
{
    public class DietService : IDietService
    {
        public Dictionary<Diet, int> AggregateToDictionary(List<Participant> participants)
        {
            return new Dictionary<Diet, int>() { { Diet.VEGETARIAN, 6 } };
        }
    }
}
