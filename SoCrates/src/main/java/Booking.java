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
