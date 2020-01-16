import org.junit.jupiter.api.Test;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;

import static org.assertj.core.api.Assertions.assertThat;

public class CountColdMealsTest {

    LocalDateTime beginOfColdMeal = LocalDateTime.of(2020, 10, 29, 21, 0);
    LocalDateTime endOfColdMeal = LocalDateTime.of(2020, 10, 30, 1, 0);

    @Test
    void allDatesAreColdMeal() {
        List<CheckIn> checkIns = new ArrayList<>();
        checkIns.add(new CheckIn(LocalDateTime.of(2020, 10, 29, 21, 30)));
        checkIns.add(new CheckIn(LocalDateTime.of(2020, 10, 29, 22, 0)));
        checkIns.add(new CheckIn(LocalDateTime.of(2020, 10, 29, 22, 30)));
        checkIns.add(new CheckIn(LocalDateTime.of(2020, 10, 29, 23, 0)));

        ColdMealCounter coldMealCounter = new ColdMealCounter(checkIns,beginOfColdMeal, endOfColdMeal);
        assertThat(coldMealCounter.countColdMeals()).isEqualTo(checkIns.size());
    }

    @Test
    void noneDatesAreColdMeal() {
        List<CheckIn> checkIns = new ArrayList<>();
        checkIns.add(new CheckIn(LocalDateTime.of(2020, 10, 28, 21, 0)));
        checkIns.add(new CheckIn(LocalDateTime.of(2020, 10, 29, 1, 0)));
        checkIns.add(new CheckIn(LocalDateTime.of(2020, 12, 29, 22, 0)));
        checkIns.add(new CheckIn(LocalDateTime.of(2020, 1, 29, 23, 0)));

        ColdMealCounter coldMealCounter = new ColdMealCounter(checkIns,beginOfColdMeal, endOfColdMeal);
        assertThat(coldMealCounter.countColdMeals()).isEqualTo(0);
    }

    @Test
    void someDatesAreColdMeal() {
        List<CheckIn> checkIns = new ArrayList<>();
        checkIns.add(new CheckIn(LocalDateTime.of(2020, 10, 29, 21, 30)));
        checkIns.add(new CheckIn(LocalDateTime.of(2020, 12, 29, 22, 0)));
        checkIns.add(new CheckIn(LocalDateTime.of(2020, 10, 30, 3, 30)));
        checkIns.add(new CheckIn(LocalDateTime.of(2020, 10, 29, 23, 0)));

        ColdMealCounter coldMealCounter = new ColdMealCounter(checkIns,beginOfColdMeal, endOfColdMeal);
        assertThat(coldMealCounter.countColdMeals()).isEqualTo(2);
    }

}
