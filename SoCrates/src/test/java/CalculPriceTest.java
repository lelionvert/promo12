import org.junit.jupiter.api.Test;

import java.time.LocalDateTime;

import static org.assertj.core.api.Assertions.assertThat;
import static org.junit.jupiter.api.Assertions.*;

class CalculPriceTest {

    @Test
    void allMealsAndSingleAccommodation() {
        CalculPrice calculPrice = new CalculPrice();
        String name = "a";
        LocalDateTime dateCheckIn = LocalDateTime.of(2020, 10, 29, 19, 0 );
        LocalDateTime dateCheckout = LocalDateTime.of(2020, 11, 1, 18, 0 );
        AccommodationType accommodationType = AccommodationType.SINGLE;
        Booking booking = new Booking(name, dateCheckIn, dateCheckout, accommodationType);

        assertThat(calculPrice.price(booking)).isEqualTo(610);
    }

    @Test
    void allMealsAndTwinAccommodation() {
        CalculPrice calculPrice = new CalculPrice();
        String name = "a";
        LocalDateTime dateCheckIn = LocalDateTime.of(2020, 10, 29, 19, 0 );
        LocalDateTime dateCheckout = LocalDateTime.of(2020, 11, 1, 18, 0 );
        AccommodationType accommodationType = AccommodationType.TWIN;
        Booking booking = new Booking(name, dateCheckIn, dateCheckout, accommodationType);

        assertThat(calculPrice.price(booking)).isEqualTo(510);
    }

    @Test
    void allMealsAndTripleAccommodation() {
        CalculPrice calculPrice = new CalculPrice();
        String name = "a";
        LocalDateTime dateCheckIn = LocalDateTime.of(2020, 10, 29, 19, 0 );
        LocalDateTime dateCheckout = LocalDateTime.of(2020, 11, 1, 18, 0 );
        AccommodationType accommodationType = AccommodationType.TRIPLE;
        Booking booking = new Booking(name, dateCheckIn, dateCheckout, accommodationType);

        assertThat(calculPrice.price(booking)).isEqualTo(410);
    }

    @Test
    void allMealsAndNoAccommodation() {
        CalculPrice calculPrice = new CalculPrice();
        String name = "a";
        LocalDateTime dateCheckIn = LocalDateTime.of(2020, 10, 29, 19, 0 );
        LocalDateTime dateCheckout = LocalDateTime.of(2020, 11, 1, 18, 0 );
        AccommodationType accommodationType = AccommodationType.NONE;
        Booking booking = new Booking(name, dateCheckIn, dateCheckout, accommodationType);

        assertThat(calculPrice.price(booking)).isEqualTo(240);
    }
}