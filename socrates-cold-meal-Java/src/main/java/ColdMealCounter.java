import java.time.LocalDateTime;
import java.time.Month;

public class ColdMealCounter {

    public boolean isColdMeal(LocalDateTime date) {

        LocalDateTime ninePm = LocalDateTime.of(2020, 10, 29, 21, 00);

        if(date.isBefore(ninePm)){
            return false;
        }

        if(date.isAfter(LocalDateTime.of(2020, 10, 30, 1, 00))){
            return false;
        }

        if(date.isEqual(ninePm)){
            return false;
        }


        return true;
    }
}
