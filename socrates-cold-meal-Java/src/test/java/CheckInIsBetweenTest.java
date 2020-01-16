import org.junit.jupiter.api.Test;

import java.time.LocalDateTime;

import static org.junit.jupiter.api.Assertions.assertFalse;
import static org.junit.jupiter.api.Assertions.assertTrue;

class CheckInIsBetweenTest {

    LocalDateTime begin = LocalDateTime.of(2020, 10, 29, 21, 0);
    LocalDateTime end = LocalDateTime.of(2020, 10, 30, 1, 0);


    @Test
    void beforeBegin() {
        CheckIn checkIn = new CheckIn(LocalDateTime.of(2020, 10, 17, 21, 0));
        assertFalse(checkIn.isBetween(begin, end));
    }

    @Test
    void atBegin() {
        CheckIn checkIn = new CheckIn(begin);
        assertTrue(checkIn.isBetween(begin, end));
    }

    @Test
    void betweenBeginAndEnd() {
        CheckIn checkIn = new CheckIn(LocalDateTime.of(2020, 10, 29, 22, 0));
        assertTrue(checkIn.isBetween(begin, end));
    }

    @Test
    void atEnd() {
        CheckIn checkIn = new CheckIn(end);
        assertFalse(checkIn.isBetween(begin, end));
    }

    @Test
    void afterEnd() {
        CheckIn checkIn = new CheckIn(LocalDateTime.of(2020, 10, 31, 22, 0));
        assertFalse(checkIn.isBetween(begin, end));
    }
}
