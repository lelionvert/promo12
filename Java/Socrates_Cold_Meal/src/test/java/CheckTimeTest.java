import org.assertj.core.api.Assertions;
import org.junit.jupiter.api.Test;

import java.time.LocalDateTime;

public class CheckTimeTest {

    @Test
    public void FindCheckInAfter21HWihtDateTest(){
        LocalDateTime ldt = LocalDateTime.of(2020, 1,16,22,0);
        Assertions.assertThat(Count.FindCheckInAfter21H(ldt)).isTrue();
    }

    @Test
    public void FindCheckInBefore1HWihtDateTest(){
        LocalDateTime ldt = LocalDateTime.of(2020,1,17,0,30);
        Assertions.assertThat(Count.FindChecInkBefore1H(ldt)).isTrue();
    }
}
