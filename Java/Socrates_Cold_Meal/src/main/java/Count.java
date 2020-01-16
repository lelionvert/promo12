import java.time.DayOfWeek;
import java.time.LocalDateTime;
import java.time.LocalTime;
import java.util.List;

public class Count {

    static LocalTime lt21H = LocalTime.of(21,0);
    static LocalTime lt1H = LocalTime.of(1,0);

    private boolean findCheckInAfter21H(LocalDateTime checkInDate) {
        LocalTime checkIn = LocalTime.of(checkInDate.getHour(),checkInDate.getMinute());
        return checkIn.isAfter(lt21H);
    }

    private boolean findChecInkBefore1H(LocalDateTime ldt) {
        LocalTime lt = LocalTime.of(ldt.getHour(),ldt.getMinute());
        return lt.isBefore(lt1H);
    }

    private boolean isCheckInAfterBegin(LocalDateTime checkInDate) {
        return checkInDate.getDayOfWeek().equals(DayOfWeek.THURSDAY) && findCheckInAfter21H(checkInDate);
    }

    private boolean isCheckInkBeforeEnd(LocalDateTime checkInDate) {
        return checkInDate.getDayOfWeek().equals(DayOfWeek.FRIDAY) && findChecInkBefore1H(checkInDate);
    }

    public boolean findCheckInForColdMeal(LocalDateTime ldt) {
        return isCheckInAfterBegin(ldt) || isCheckInkBeforeEnd(ldt);
    }

    public Long coldMeal(List<LocalDateTime> checkIns) {
        return checkIns.stream().filter(this::findCheckInForColdMeal).count();
    }
}
