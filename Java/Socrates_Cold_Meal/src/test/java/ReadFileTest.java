import org.assertj.core.api.Assertions;
import org.junit.jupiter.api.Test;

import java.io.IOException;

public class ReadFileTest {
    @Test
    public void Read70DateTest() throws IOException {
        Assertions.assertThat(ReadFile.read().size()).isEqualTo(70);
    }

    /*@Test
    public void invalidDate(){
        assertThrows(DateTimeParseException.class, () -> {
            CheckIn.of("32/10/2020 19:32", "dd/MM/yyyy HH:mm");
        });
    }*/
}
