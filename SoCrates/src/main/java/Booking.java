import java.time.LocalDateTime;

public class Booking {

    private final String name;
    private final LocalDateTime dateCheckIn;
    private final LocalDateTime dateCheckout;
    private final AccommodationType accommodationType;

    public Booking(String name, LocalDateTime dateCheckIn, LocalDateTime dateCheckout, AccommodationType accommodationType) {
        this.name = name;
        this.dateCheckIn = dateCheckIn;
        this.dateCheckout = dateCheckout;
        this.accommodationType = accommodationType;
    }


}
