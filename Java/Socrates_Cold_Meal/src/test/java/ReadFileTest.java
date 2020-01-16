import org.assertj.core.api.Assertions;
import org.junit.jupiter.api.Test;

import java.io.IOException;

public class ReadFileTest {
    @Test
    public void Read70DateTest() throws IOException {
        Assertions.assertThat(ReadFile.read().size()).isEqualTo(70);
    }
}
