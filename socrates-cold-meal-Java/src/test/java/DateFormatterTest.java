import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

import java.time.LocalDateTime;
import java.time.format.DateTimeParseException;

import static org.assertj.core.api.Assertions.assertThat;

class DateFormatterTest {

    @Test
    public void validDate(){
        DateFormatter dateFormatter = new DateFormatter();
        assertThat(dateFormatter.textToDate("29/10/2020 19:32", "dd/MM/yyyy HH:mm"))
                .isEqualTo(LocalDateTime.of(2020, 10, 29, 19, 32));
    }

    @Test
    public void invalidDate(){
        DateFormatter dateFormatter = new DateFormatter();
        Assertions.assertThrows(DateTimeParseException.class, () -> {
            dateFormatter.textToDate("32/10/2020 19:32", "dd/MM/yyyy HH:mm");
        });
    }

    @Test
    public void emptyDate(){
        DateFormatter dateFormatter = new DateFormatter();
        Assertions.assertThrows(DateTimeParseException.class, () -> {
            dateFormatter.textToDate("", "dd/MM/yyyy HH:mm");
        });
    }

    @Test
    public void notADate(){
        DateFormatter dateFormatter = new DateFormatter();
        Assertions.assertThrows(DateTimeParseException.class, () -> {
            dateFormatter.textToDate("NOT A DATE", "dd/MM/yyyy HH:mm");
        });
    }


}