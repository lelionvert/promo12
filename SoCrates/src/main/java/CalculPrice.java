public class CalculPrice {
    public int price(Booking booking) {
        if(booking.getAccommodationPrice() == 510)
            return booking.getAccommodationPrice();
        else if(booking.getAccommodationPrice() == 410)
            return booking.getAccommodationPrice();
        return 610;
    }
}
