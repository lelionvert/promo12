import org.assertj.core.api.Assertions;
import org.junit.jupiter.api.Test;

import java.util.List;


class CSVReaderTest {

    @Test
    public void ReadCsvFile()
    {
        List<String> fileContents = CSVReader.readFile("C:\\Users\\LaCombeDuLionVert_2\\Downloads\\Choices.csv");
        Assertions.assertThat(fileContents).isEqualTo("");
    }

}