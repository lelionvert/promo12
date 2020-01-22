import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.io.Reader;
import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;

import static org.assertj.core.api.Assertions.assertThat;

public class DietCounterIT {

    private List<Booking> bookings = new ArrayList<>();
    private DietCounter dietCounter = new DietCounter();

    @BeforeEach
    public void setUp() {

        bookings.add(new Booking(LocalDateTime.of(2020, 10, 29, 15, 0),
                LocalDateTime.of(2020, 11, 1, 15, 0), AccommodationType.SINGLE, Diet.VEGETARIAN));

        bookings.add(new Booking(LocalDateTime.of(2020, 10, 29, 23, 0),
                LocalDateTime.of(2020, 11, 1, 8, 0), AccommodationType.SINGLE, Diet.VEGETARIAN));


        bookings.add(new Booking(LocalDateTime.of(2020, 10, 29, 15, 0),
                LocalDateTime.of(2020, 11, 1, 15, 0), AccommodationType.SINGLE, Diet.PESCATARIAN));


        bookings.add(new Booking(LocalDateTime.of(2020, 10, 29, 15, 0),
                LocalDateTime.of(2020, 11, 1, 8, 0), AccommodationType.SINGLE, Diet.VEGAN));


        bookings.add(new Booking(LocalDateTime.of(2020, 10, 29, 15, 0),
                LocalDateTime.of(2020, 11, 1, 15, 0), AccommodationType.SINGLE, Diet.DEFAULT));

    }


    @Test
    public void RENAME(){

        //CSV
        String path = "";

        //Mock
        IReader reader = new Reader(path);

        List<Booking> bookings = reader.getBookings();

        //Mock
        IDietCounter dietCounter = new DietCounter();

        Map<Diet, Integer> coverDiet = dietCounter.getCoverDiet(bookings);

        IRender.
    }

}

