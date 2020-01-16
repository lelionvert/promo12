import java.time.LocalDateTime;
import java.util.List;

public class ColdMealCounter {

    private List<CheckIn> checkIns;
    private LocalDateTime beginOfColdMeal;
    private LocalDateTime endOfColdMeal;

    public ColdMealCounter(List<CheckIn> checkIns, LocalDateTime beginOfColdMeal, LocalDateTime endOfColdMeal) {
        this.checkIns = checkIns;
        this.beginOfColdMeal = beginOfColdMeal;
        this.endOfColdMeal = endOfColdMeal;
    }

    public int countColdMeals() {
        return (int) checkIns.stream().filter(checkIn -> checkIn.isBetween(beginOfColdMeal, endOfColdMeal)).count();
    }
}