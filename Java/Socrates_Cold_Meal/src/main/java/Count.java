import java.time.DayOfWeek;
import java.time.LocalDateTime;
import java.time.LocalTime;
import java.util.List;

public class Count {

    static LocalTime lt21H = LocalTime.of(21,0);
    static LocalTime lt1H = LocalTime.of(1,0);

    public static boolean FindCheckInAfter21H(LocalDateTime ldt) {
        LocalTime lt = LocalTime.of(ldt.getHour(),ldt.getMinute());
        return lt.isAfter(lt21H);
    }

    public static boolean FindChecInkBefore1H(LocalDateTime ldt) {
        LocalTime lt = LocalTime.of(ldt.getHour(),ldt.getMinute());
        return lt.isBefore(lt1H);
    }

    public static boolean FindCheckInAfter21HInThursday(LocalDateTime ldt) {
        return ldt.getDayOfWeek().equals(DayOfWeek.THURSDAY) && FindCheckInAfter21H(ldt);
    }

    public static boolean FindChecInkBefore1HInFriday(LocalDateTime ldt) {
        return ldt.getDayOfWeek().equals(DayOfWeek.FRIDAY) && FindChecInkBefore1H(ldt);
    }

    public static boolean FindChecInForColdMeal(LocalDateTime ldt) {
        return FindCheckInAfter21HInThursday(ldt) || FindChecInkBefore1HInFriday(ldt);
    }

    public static int ColdMeal(List<LocalDateTime> checkIn) {
        int count = 0;
        // TODO convert to stream
        for (LocalDateTime ldt : checkIn){
            if (FindChecInForColdMeal(ldt)){
                count++;
            }
        }
        return count;
    }
}
