import org.assertj.core.api.Assertions;
import org.junit.jupiter.api.Test;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;

public class CountTest {

    @Test
    public void return1For1CheckInDateColdMealTest(){
        List<CheckIn> checkIns = new ArrayList<>();
        checkIns.add(new CheckIn(LocalDateTime.of(2020, 1,16,22,0)));
        Count count = new Count();
        Assertions.assertThat(count.coldMeal(checkIns)).isEqualTo(1);
    }

    @Test
    public void return2For2CheckInDateColdMealTest(){
        List<CheckIn> checkIn = new ArrayList<>();
        checkIn.add(new CheckIn(LocalDateTime.of(2020, 1,16,22,0)));
        checkIn.add(new CheckIn(LocalDateTime.of(2020, 1,17,0,30)));
        Count count = new Count();
        Assertions.assertThat(count.coldMeal(checkIn)).isEqualTo(2);
    }

    @Test
    public void return1For1CheckInDateColdMealAndAnotherTimeThursdayTest(){
        List<CheckIn> checkIn = new ArrayList<>();
        checkIn.add(new CheckIn(LocalDateTime.of(2020, 1,16,22,0)));
        checkIn.add(new CheckIn(LocalDateTime.of(2020, 1,16,0,30)));
        Count count = new Count();
        Assertions.assertThat(count.coldMeal(checkIn)).isEqualTo(1);
    }

    @Test
    public void Return1For1CheckInDateColdMealAndAnotherTimeFridayTest(){
        List<CheckIn> checkIn = new ArrayList<>();
        checkIn.add(new CheckIn(LocalDateTime.of(2020, 1,16,22,0)));
        checkIn.add(new CheckIn(LocalDateTime.of(2020, 1,17,2,30)));
        Count count = new Count();
        Assertions.assertThat(count.coldMeal(checkIn)).isEqualTo(1);
    }

}
