import java.time.LocalDateTime;

public class Meal {
    private final LocalDateTime beginningOfMeal;
    private final LocalDateTime endOfMeal;

    public Meal(LocalDateTime beginningOfMeal, LocalDateTime endOfMeal) {
        this.beginningOfMeal = beginningOfMeal;
        this.endOfMeal = endOfMeal;
    }
}
