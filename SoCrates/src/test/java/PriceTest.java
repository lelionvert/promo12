import org.assertj.core.api.Assertions;
import org.junit.jupiter.api.Test;

import java.time.LocalDateTime;

import static org.assertj.core.api.Assertions.assertThat;

public class PriceTest {

    @Test
    void allMealsAndSingleAccommodation() {
        CalculPrice calculPrice = new CalculPrice();
        String name = "a";
        LocalDateTime dateCheckIn = LocalDateTime.of(2020, 10, 29, 19, 0 );;
        LocalDateTime dateCheckout = LocalDateTime.of(2020, 11, 1, 18, 0 );
        AccommodationType accommodationType = AccommodationType.SINGLE;
        Booking booking = new Booking(name, dateCheckIn, dateCheckout, accommodationType);

        assertThat(calculPrice.price(booking)).isEqualTo(610);
    }

}
