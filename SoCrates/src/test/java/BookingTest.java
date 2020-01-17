import org.junit.jupiter.api.Test;

import java.time.LocalDateTime;

import static org.assertj.core.api.Assertions.assertThat;

public class BookingTest {

    LocalDateTime firstDayMealsTime  = LocalDateTime.of(2020, 10, 29, 19, 0 );
    LocalDateTime secondDayMealsTime  = LocalDateTime.of(2020, 10, 29, 19, 0 );

    @Test
    void zeroMealsMissed() {
        LocalDateTime dateCheckIn = LocalDateTime.of(2020, 10, 29, 19, 0 );
        LocalDateTime dateCheckout = LocalDateTime.of(2020, 11, 1, 18, 0 );
        Booking booking = new Booking("name", dateCheckIn, dateCheckout, AccommodationType.SINGLE);

        assertThat(booking.numberOfMissedMeals(firstDayMealsTime, secondDayMealsTime)).isEqualTo(0);
    }


}
