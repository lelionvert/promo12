import java.time.DayOfWeek;
import java.time.LocalDateTime;
import java.time.LocalTime;

public class CheckIn {
    private LocalDateTime checkInDate;

    private final static LocalTime h21 = LocalTime.of(21,0);
    private final static LocalTime h1 = LocalTime.of(1,0);

    public CheckIn(LocalDateTime checkIn) {
        this.checkInDate = checkIn;
    }

    private boolean isAfter21H() {
        LocalTime checkIn = LocalTime.of(checkInDate.getHour(),checkInDate.getMinute());
        return checkIn.isAfter(h21);
    }

    private boolean isBefore1H() {
        LocalTime checkIn = LocalTime.of(checkInDate.getHour(),checkInDate.getMinute());
        return checkIn.isBefore(h1);
    }

    private boolean isAfterBegin() {
        return checkInDate.getDayOfWeek().equals(DayOfWeek.THURSDAY) && isAfter21H();
    }

    private boolean isBeforeEnd() {
        return checkInDate.getDayOfWeek().equals(DayOfWeek.FRIDAY) && isBefore1H();
    }

    public boolean isBetweenBeginAndEnd() {
        return isAfterBegin() || isBeforeEnd();
    }
}
