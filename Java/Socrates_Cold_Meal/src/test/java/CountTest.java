import org.assertj.core.api.Assertions;
import org.junit.jupiter.api.Test;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;

public class CountTest {

    @Test
    public void Return1For1CheckInDateColdMealTest(){
        List<LocalDateTime> checkIn = new ArrayList<LocalDateTime>();
        checkIn.add(LocalDateTime.of(2020, 1,16,22,0));
        Assertions.assertThat(Count.ColdMeal(checkIn)).isEqualTo(1);
    }

    @Test
    public void Return2For2CheckInDateColdMealTest(){
        List<LocalDateTime> checkIn = new ArrayList<LocalDateTime>();
        checkIn.add(LocalDateTime.of(2020, 1,16,22,0));
        checkIn.add(LocalDateTime.of(2020, 1,17,0,30));
        Assertions.assertThat(Count.ColdMeal(checkIn)).isEqualTo(2);
    }

    @Test
    public void Return1For1CheckInDateColdMealAndAnotherTimeThursdayTest(){
        List<LocalDateTime> checkIn = new ArrayList<LocalDateTime>();
        checkIn.add(LocalDateTime.of(2020, 1,16,22,0));
        checkIn.add(LocalDateTime.of(2020, 1,16,0,30));
        Assertions.assertThat(Count.ColdMeal(checkIn)).isEqualTo(1);
    }

    @Test
    public void Return1For1CheckInDateColdMealAndAnotherTimeFridayTest(){
        List<LocalDateTime> checkIn = new ArrayList<LocalDateTime>();
        checkIn.add(LocalDateTime.of(2020, 1,16,22,0));
        checkIn.add(LocalDateTime.of(2020, 1,17,2,30));
        Assertions.assertThat(Count.ColdMeal(checkIn)).isEqualTo(1);
    }


}
