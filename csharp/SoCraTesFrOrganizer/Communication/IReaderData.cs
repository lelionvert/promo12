using System.Collections.Generic;

namespace SoCraTesFrOrganizer.Communication
{
    public interface IReaderData
    {
        List<string> ReadFile(string filePath);

        List<Booking> MapToBooking(List<string> fileContents);
    }
}