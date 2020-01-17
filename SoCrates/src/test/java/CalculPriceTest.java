import org.junit.jupiter.api.Test;

import java.time.LocalDateTime;

import static org.assertj.core.api.Assertions.assertThat;

class CalculPriceTest {

    LocalDateTime firstDayMealsTime  = LocalDateTime.of(2020, 10, 30, 1, 0 );
    LocalDateTime lastDayMealsTime = LocalDateTime.of(2020, 11, 1, 14, 0 );
    CalculPrice calculPrice = new CalculPrice(firstDayMealsTime, lastDayMealsTime);
    String name = "a";

    @Test
    void allMealsAndSingleAccommodation() {
        LocalDateTime dateCheckIn = LocalDateTime.of(2020, 10, 29, 19, 0 );
        LocalDateTime dateCheckout = LocalDateTime.of(2020, 11, 1, 18, 0 );
        AccommodationType accommodationType = AccommodationType.SINGLE;
        Booking booking = new Booking(name, dateCheckIn, dateCheckout, accommodationType);

        assertThat(calculPrice.price(booking)).isEqualTo(610);
    }

    @Test
    void allMealsAndTwinAccommodation() {
        LocalDateTime dateCheckIn = LocalDateTime.of(2020, 10, 29, 19, 0 );
        LocalDateTime dateCheckout = LocalDateTime.of(2020, 11, 1, 18, 0 );
        AccommodationType accommodationType = AccommodationType.TWIN;
        Booking booking = new Booking(name, dateCheckIn, dateCheckout, accommodationType);

        assertThat(calculPrice.price(booking)).isEqualTo(510);
    }

    @Test
    void allMealsAndTripleAccommodation() {
        LocalDateTime dateCheckIn = LocalDateTime.of(2020, 10, 29, 19, 0 );
        LocalDateTime dateCheckout = LocalDateTime.of(2020, 11, 1, 18, 0 );
        AccommodationType accommodationType = AccommodationType.TRIPLE;
        Booking booking = new Booking(name, dateCheckIn, dateCheckout, accommodationType);

        assertThat(calculPrice.price(booking)).isEqualTo(410);
    }

    @Test
    void allMealsAndNoAccommodation() {
        LocalDateTime dateCheckIn = LocalDateTime.of(2020, 10, 29, 19, 0 );
        LocalDateTime dateCheckout = LocalDateTime.of(2020, 11, 1, 18, 0 );
        AccommodationType accommodationType = AccommodationType.NONE;
        Booking booking = new Booking(name, dateCheckIn, dateCheckout, accommodationType);

        assertThat(calculPrice.price(booking)).isEqualTo(240);
    }

    @Test
    void oneMealMissedAndNoAccommodation() {
        LocalDateTime dateCheckIn = LocalDateTime.of(2020, 10, 30, 11, 0 );
        LocalDateTime dateCheckout = LocalDateTime.of(2020, 11, 1, 18, 0 );
        AccommodationType accommodationType = AccommodationType.NONE;
        Booking booking = new Booking(name, dateCheckIn, dateCheckout, accommodationType);

        assertThat(calculPrice.price(booking)).isEqualTo(200);
    }


    @Test
    void twoMealsMissedAndNoAccommodation() {
        LocalDateTime dateCheckIn = LocalDateTime.of(2020, 10, 30, 11, 0 );
        LocalDateTime dateCheckout = LocalDateTime.of(2020, 11, 1, 13, 0 );
        AccommodationType accommodationType = AccommodationType.NONE;
        Booking booking = new Booking(name, dateCheckIn, dateCheckout, accommodationType);

        assertThat(calculPrice.price(booking)).isEqualTo(160);
    }


}