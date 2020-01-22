import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

public class Booking {

    private final LocalDateTime dateCheckIn;
    private final LocalDateTime dateCheckout;
    private final AccommodationType accommodationType;
    private  Diet diet;


    public static Booking of(String bookingText)
    {
        String[] data = bookingText.split(";");
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd/MM/yyyy HH:mm");

        LocalDateTime dateCheckIn = LocalDateTime.parse(data[1], formatter);;
        LocalDateTime dateCheckout = LocalDateTime.parse(data[2], formatter);;
        AccommodationType accommodationType = AccommodationType.valueOf(data[3]);
        Diet diet = Diet.valueOf(data[4].toUpperCase());

        return new Booking(dateCheckIn, dateCheckout, accommodationType, diet);
    }

    public Booking(LocalDateTime dateCheckIn, LocalDateTime dateCheckout, AccommodationType accommodationType, Diet diet) {
        this.dateCheckIn = dateCheckIn;
        this.dateCheckout = dateCheckout;
        this.accommodationType = accommodationType;
        this.diet = diet;
    }

    public Booking(LocalDateTime dateCheckIn, LocalDateTime dateCheckout, AccommodationType accommodationType) {
        this.dateCheckIn = dateCheckIn;
        this.dateCheckout = dateCheckout;
        this.accommodationType = accommodationType;
    }

    public int getAccommodationPrice() {
        return this.accommodationType.getPrice();
    }

    public int numberOfMissedMeals(LocalDateTime firstDayMealsTime, LocalDateTime lastDayMealsTime) {

        if(dateCheckout.isBefore(lastDayMealsTime) && dateCheckIn.isAfter(firstDayMealsTime)){
            return 2;
        }
        if (dateCheckout.isBefore(lastDayMealsTime) || dateCheckIn.isAfter(firstDayMealsTime)) {
            return 1;
        }
        return 0;
    }
}
