import java.util.List;

public class Count {

    public Long coldMeal(List<CheckIn> checkIns) {
        return checkIns.stream().filter(CheckIn::isBetweenBeginAndEnd).count();
    }
}
