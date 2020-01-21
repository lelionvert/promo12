using System.Collections.Generic;

namespace SoCraTesFrOrganizer
{
    public interface IImportData
    {
        List<string> ReadFile(string filePath);

        List<Booking> MapToBooking(List<string> fileContents);
    }
}