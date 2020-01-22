import java.time.LocalDateTime;

public class CalculatePrice {

    LocalDateTime firstDayMealsTime;
    LocalDateTime lastDayMealsTime;
    int mealPrice;

    public CalculatePrice(LocalDateTime firstDayMealsTime, LocalDateTime lastDayMealsTime, int mealPrice) {
        this.firstDayMealsTime = firstDayMealsTime;
        this.lastDayMealsTime = lastDayMealsTime;
        this.mealPrice = mealPrice;
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
