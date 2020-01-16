import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

public class DateFormatter {
    public LocalDateTime textToDate(String dateString, String dateFormat) {
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern(dateFormat);
        return LocalDateTime.parse(dateString, formatter);
    }
}
