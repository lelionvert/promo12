using System.Collections.Generic;

namespace KataSocrates.Domain
{
    public interface IDietService
    {
        Dictionary<Diet, int> AggregateToDictionary(List<Participant> participants);
    }
}
