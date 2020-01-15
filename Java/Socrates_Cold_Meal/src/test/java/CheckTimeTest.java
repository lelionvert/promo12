import org.assertj.core.api.Assertions;
import org.junit.jupiter.api.Test;

import java.time.LocalDateTime;

public class CheckTimeTest {

    @Test
    public void FindCheckInAfter21HWihtDateTest(){
        LocalDateTime ldt = LocalDateTime.of(2020,01,16,22,00);
        Assertions.assertThat(Count.FindCheckInAfter21H(ldt)).isTrue();
    }
}
