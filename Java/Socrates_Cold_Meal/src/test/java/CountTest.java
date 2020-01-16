import org.assertj.core.api.Assertions;
import org.junit.jupiter.api.Test;

import java.time.LocalDateTime;

public class CountTest {

    @Test
    public void Return1For1CheckInDateColdMealTest(){
        LocalDateTime ldt = LocalDateTime.of(2020, 1,16,22,0);
        Assertions.assertThat(Count.ColdMeal(ldt)).isEqualTo(1);
    }
}
