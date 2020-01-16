import org.junit.jupiter.api.Test;

import javax.swing.text.DateFormatter;
import java.time.LocalDateTime;
import java.time.format.DateTimeParseException;

import static org.assertj.core.api.Assertions.assertThat;
import static org.junit.jupiter.api.Assertions.assertThrows;

class CheckInDateFormatTest {

    @Test
    public void validDate(){
        CheckIn checkIn = CheckIn.of("29/10/2020 19:32", "dd/MM/yyyy HH:mm");
        assertThat(checkIn)
                .isEqualToComparingFieldByField(new CheckIn(LocalDateTime.of(2020, 10, 29, 19, 32)));
    }

    @Test
    public void invalidDate(){
        assertThrows(DateTimeParseException.class, () -> {
            CheckIn.of("32/10/2020 19:32", "dd/MM/yyyy HH:mm");
        });
    }

    @Test
    public void emptyDate() {
        assertThrows(DateTimeParseException.class, () -> {
            CheckIn.of("", "dd/MM/yyyy HH:mm");
        });
    }

    @Test
    public void notADate(){
        assertThrows(DateTimeParseException.class, () -> {
            CheckIn.of("NOT A DATE", "dd/MM/yyyy HH:mm");
        });
    }

    @Test
    public void notAValidFormat(){
        assertThrows(IllegalArgumentException.class, () -> {
            CheckIn.of("NOT A DATE", "dd/OO/yyyy HH:mm");
        });
    }

}