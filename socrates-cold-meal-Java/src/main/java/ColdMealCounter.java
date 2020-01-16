import java.time.LocalDateTime;
import java.util.List;

public class ColdMealCounter {

    public boolean isColdMeal(LocalDateTime date) {
        LocalDateTime ninePm = LocalDateTime.of(2020, 10, 29, 21, 0);
        LocalDateTime oneAm = LocalDateTime.of(2020, 10, 30, 1, 0);

        boolean isNotBetween9pmAnd1am = date.isBefore(ninePm) || date.isEqual(ninePm) || date.isAfter(oneAm);
        if(isNotBetween9pmAnd1am){
            return false;
        }
        return true;
    }

    public int count(List<LocalDateTime> dates) {
        return (int) dates.stream().filter(this::isColdMeal).count();
    }
}
