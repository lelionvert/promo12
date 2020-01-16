import java.time.DayOfWeek;
import java.time.LocalTime;
import java.util.List;

public class ColdMeal {

    LocalTime startTimeColdMeal = LocalTime.of(21,0);
    LocalTime endTimeColdMeal = LocalTime.of(1,0);
    DayOfWeek startDay = DayOfWeek.THURSDAY;
    DayOfWeek endDay = DayOfWeek.FRIDAY;

    public Long count(List<CheckIn> checkIns) {
        return checkIns.stream()
                .filter(checkIn -> checkIn.isBetween(startTimeColdMeal, endTimeColdMeal, startDay, endDay))
                .count();
    }

}
