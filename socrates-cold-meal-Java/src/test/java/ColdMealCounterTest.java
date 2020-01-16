import org.junit.jupiter.api.Test;

import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

import static org.assertj.core.api.Assertions.assertThat;
import static org.junit.jupiter.api.Assertions.assertFalse;
import static org.junit.jupiter.api.Assertions.assertTrue;

class IsColdMealTest {


    @Test
    void between9pmAnd1am() {
        ColdMealCounter coldMealCounter = new ColdMealCounter();
        assertTrue(coldMealCounter.isColdMeal(LocalDateTime.of(2020, 10, 29, 22, 00)));
    }

    @Test
    void before9pm() {
        ColdMealCounter coldMealCounter = new ColdMealCounter();
        assertFalse(coldMealCounter.isColdMeal(LocalDateTime.of(2020, 10, 29, 19, 00)));

    }

    @Test
    void after1am() {
        ColdMealCounter coldMealCounter = new ColdMealCounter();
        assertFalse(coldMealCounter.isColdMeal(LocalDateTime.of(2020, 10, 30, 4, 00)));
    }

    @Test
    void between9pmAnd1amDifferentDay() {
        ColdMealCounter coldMealCounter = new ColdMealCounter();
        assertFalse(coldMealCounter.isColdMeal(LocalDateTime.of(2020, 11, 29, 22, 00)));
    }

    @Test
    void at9pm() {
        ColdMealCounter coldMealCounter = new ColdMealCounter();
        assertFalse(coldMealCounter.isColdMeal(LocalDateTime.of(2020, 10, 29, 21, 00)));
    }

    @Test
    void at1am() {
        ColdMealCounter coldMealCounter = new ColdMealCounter();
        assertTrue(coldMealCounter.isColdMeal(LocalDateTime.of(2020, 10, 30, 1, 00)));
    }


}