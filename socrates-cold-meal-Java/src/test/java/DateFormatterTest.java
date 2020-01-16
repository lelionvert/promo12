import org.junit.jupiter.api.Test;

import java.time.LocalDateTime;

import static org.assertj.core.api.Assertions.assertThat;

class DateFormatterTest {

    @Test
    public void validDate(){
        DateFormatter dateFormatter = new DateFormatter();
        assertThat(dateFormatter.textToDate("29/10/2020 19:32")).isEqualTo(LocalDateTime.of(2020, 10, 29, 19, 32));
    }

}