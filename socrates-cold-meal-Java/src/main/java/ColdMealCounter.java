import java.time.LocalDateTime;

public class ColdMealCounter {

    public boolean isColdMeal(LocalDateTime date) {

        LocalDateTime ninePm = LocalDateTime.of(2020, 10, 29, 21, 00);
        LocalDateTime oneAm = LocalDateTime.of(2020, 10, 30, 1, 00);

        if(date.isBefore(ninePm) || date.isEqual(ninePm) || date.isAfter(oneAm)){
            return false;
        }

        return true;
    }
}
