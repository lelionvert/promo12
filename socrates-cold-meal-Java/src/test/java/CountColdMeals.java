import org.junit.jupiter.api.Test;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;

import static org.assertj.core.api.Assertions.assertThat;

public class CountColdMeals {
    @Test
    void allDatesAreColdMeal() {
        List<LocalDateTime> dates = new ArrayList<>();
        dates.add(LocalDateTime.of(2020, 10, 29, 21, 30));
        dates.add(LocalDateTime.of(2020, 10, 29, 22, 0));
        dates.add(LocalDateTime.of(2020, 10, 29, 22, 30));
        dates.add(LocalDateTime.of(2020, 10, 29, 23, 0));
        ColdMealCounter coldMealCounter = new ColdMealCounter();
        assertThat(coldMealCounter.count(dates)).isEqualTo(dates.size());
    }

    @Test
    void noneDatesAreColdMeal() {
        List<LocalDateTime> dates = new ArrayList<>();
        dates.add(LocalDateTime.of(2020, 10, 28, 21, 0));
        dates.add(LocalDateTime.of(2020, 10, 29, 1, 0));
        dates.add(LocalDateTime.of(2020, 12, 29, 22, 0));
        dates.add(LocalDateTime.of(2020, 1, 29, 23, 0));
        ColdMealCounter coldMealCounter = new ColdMealCounter();
        assertThat(coldMealCounter.count(dates)).isEqualTo(0);
    }


}
