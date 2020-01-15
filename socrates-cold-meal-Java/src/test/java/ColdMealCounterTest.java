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


}