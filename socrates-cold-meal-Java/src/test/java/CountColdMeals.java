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
        dates.add(LocalDateTime.of(2020, 10, 29, 22, 00));
        dates.add(LocalDateTime.of(2020, 10, 29, 22, 30));
        dates.add(LocalDateTime.of(2020, 10, 29, 23, 00));
        ColdMealCounter coldMealCounter = new ColdMealCounter();
        assertThat(coldMealCounter.count(dates)).isEqualTo(dates.size());
    }
}