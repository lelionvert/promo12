import java.time.LocalDateTime;
import java.time.Month;

public class ColdMealCounter {
    public boolean isColdMeal(LocalDateTime date) {


        if(date.isBefore(LocalDateTime.of(2020, 10, 29, 21, 00))){
            return false;
        }

        if(date.isAfter(LocalDateTime.of(2020, 10, 30, 1, 00))){
            return false;
        }

        if(date.isEqual(LocalDateTime.of(2020, 10, 29, 21, 00))){
            return false;
        }




        return true;
    }
}
