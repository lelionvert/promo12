import java.time.DayOfWeek;
import java.time.LocalDateTime;
import java.time.LocalTime;

public class Count {
    public static boolean FindCheckInAfter21H(LocalDateTime ldt) {
        LocalTime lt21H = LocalTime.of(21,0);
        LocalTime lt = LocalTime.of(ldt.getHour(),ldt.getMinute());
        return lt.isAfter(lt21H);
    }

    public static boolean FindChecInkBefore1H(LocalDateTime ldt) {
        LocalTime lt1H = LocalTime.of(1,0);
        LocalTime lt = LocalTime.of(ldt.getHour(),ldt.getMinute());
        return lt.isBefore(lt1H);
    }

    public static boolean FindCheckInAfter21HInThursday(LocalDateTime ldt) {
        return ldt.getDayOfWeek().equals(DayOfWeek.THURSDAY) && FindCheckInAfter21H(ldt);
    }

    public static boolean FindChecInkBefore1HInFriday(LocalDateTime ldt) {
        return true;
    }
}
