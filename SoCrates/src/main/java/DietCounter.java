import sun.reflect.generics.reflectiveObjects.NotImplementedException;

import java.util.EnumMap;
import java.util.List;

public class DietCounter implements IDietCounter {

    @Override
    public EnumMap<Diet, Integer> getCoverDiet(List<Booking> bookings) {
        throw new NotImplementedException();
    }
}
