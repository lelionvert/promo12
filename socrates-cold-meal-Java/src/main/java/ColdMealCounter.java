import java.time.LocalDateTime;

public class ColdMealCounter {
    public boolean isColdMeal(LocalDateTime date) {

        if(date.getHour() == 19){
            return false;
        }

        if(date.getHour() == 4){
            return false;
        }

        return true;
    }
}
