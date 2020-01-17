import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

public class CheckIn {

    private LocalDateTime checkInDate;

    public CheckIn(LocalDateTime checkInDate) {
        this.checkInDate = checkInDate;
    }

    boolean isBetween(LocalDateTime begin, LocalDateTime end) {
        return (checkInDate.isAfter(begin) || checkInDate.isEqual(begin)) && checkInDate.isBefore(end);
    }

    public static CheckIn of(String dateString, String dateFormat) {
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern(dateFormat);
        return new CheckIn(LocalDateTime.parse(dateString, formatter));
    }

}
