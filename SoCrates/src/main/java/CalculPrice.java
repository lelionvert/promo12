import java.time.LocalDateTime;

public class CalculPrice {

    LocalDateTime firstDayMealsTime;
    LocalDateTime lastDayMealsTime;
    int mealPrice = 40;

    public CalculPrice(LocalDateTime firstDayMealsTime, LocalDateTime lastDayMealsTime) {
        this.firstDayMealsTime = firstDayMealsTime;
        this.lastDayMealsTime = lastDayMealsTime;
    }

    public int price(Booking booking) {
        int missedMeals = booking.numberOfMissedMeals(firstDayMealsTime, lastDayMealsTime);
        int globalPrice = booking.getAccommodationPrice() - missedMeals * mealPrice;
        return globalPrice;
    }

    public int getMealPrice() {
        return mealPrice;
    }

    public void setMealPrice(int mealPrice) {
        this.mealPrice = mealPrice;
    }
}
