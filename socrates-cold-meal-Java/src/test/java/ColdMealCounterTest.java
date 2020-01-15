import org.assertj.core.api.Assertions;
import org.junit.jupiter.api.Test;

import java.time.LocalDateTime;

import static org.assertj.core.api.Assertions.*;
import static org.junit.jupiter.api.Assertions.*;

class ColdMealCounterTest {

    @Test
    void between9pmAnd1am() {
        ColdMealCounter coldMealCounter = new ColdMealCounter();
        assertThat(coldMealCounter.isColdMeal("29/10/2020 22:00")).isEqualTo(true);
    }
}