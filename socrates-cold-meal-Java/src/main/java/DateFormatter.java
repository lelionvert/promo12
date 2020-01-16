import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

public class DateFormatter {
    public LocalDateTime textToDate(String dateString) {
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd/MM/yyyy HH:mm");
        return LocalDateTime.parse(dateString, formatter);
    }
}
