import java.time.DayOfWeek;
import java.time.LocalDateTime;
import java.time.LocalTime;

public class CheckIn {
    private LocalDateTime checkInDate;

    public CheckIn(LocalDateTime checkIn) {
        this.checkInDate = checkIn;
    }

    private boolean isAfter(LocalTime startTime, DayOfWeek startDay) {
        LocalTime checkIn = LocalTime.of(checkInDate.getHour(),checkInDate.getMinute());
        return checkInDate.getDayOfWeek().equals(startDay) && checkIn.isAfter(startTime);
    }

    private boolean isBefore(LocalTime endTime, DayOfWeek endDay) {
        LocalTime checkIn = LocalTime.of(checkInDate.getHour(),checkInDate.getMinute());
        return checkInDate.getDayOfWeek().equals(endDay) && checkIn.isBefore(endTime);
    }

    public boolean isBetween(LocalTime startTime, LocalTime endTime, DayOfWeek startDay, DayOfWeek endDay) {
        return isAfter(startTime, startDay) || isBefore(endTime, endDay);
    }
}
