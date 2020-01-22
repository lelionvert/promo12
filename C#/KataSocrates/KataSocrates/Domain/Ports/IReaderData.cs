using System.Collections.Generic;

namespace KataSocrates.Domain
{
    public interface IReaderData
    {
        List<Participant> GetParticipants();
    }
}
