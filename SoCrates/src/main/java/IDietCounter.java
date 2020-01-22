import java.util.EnumMap;
import java.util.List;

public interface IDietCounter {

    EnumMap<Diet, Integer> getCoverDiet(List<Booking> bookings);

}
