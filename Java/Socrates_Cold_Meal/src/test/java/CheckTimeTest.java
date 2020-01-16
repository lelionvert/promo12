import org.assertj.core.api.Assertions;
import org.junit.jupiter.api.Test;

import java.time.LocalDateTime;

public class CheckTimeTest {

    @Test
    public void findCheckInAfter21HInThursdayWihtDateTest(){
        LocalDateTime chekInDate = LocalDateTime.of(2020, 1,16,22,0);
        Count count = new Count();
        Assertions.assertThat(count.findCheckInForColdMeal(chekInDate)).isTrue();
    }

    @Test
    public void findCheckInBefore1HInFridayWihtDateTest(){
        LocalDateTime checkInDate = LocalDateTime.of(2020,1,17,0,30);
        Count count = new Count();
        Assertions.assertThat(count.findCheckInForColdMeal(checkInDate)).isTrue();
    }

    @Test
    public void findCheckInBetween21HThusdayAnd1HFridayWihtDateTest(){
        LocalDateTime checInDate = LocalDateTime.of(2020,1,16,22,30);
        Count count = new Count();
        Assertions.assertThat(count.findCheckInForColdMeal(checInDate)).isTrue();
    }

}
