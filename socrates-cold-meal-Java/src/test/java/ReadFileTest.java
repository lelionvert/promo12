import org.assertj.core.api.Assertions;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvSource;

import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

import static org.assertj.core.api.Assertions.assertThat;


class ReadFileTest {

    @Test
    void readFile() {

       //assertThat(true).;
    }

    @ParameterizedTest
    @CsvSource({"Participant 1, 29/10/2020 14:32"})
    void testGetPrice(String name, LocalDateTime dateTime) {

        ReadFile readFile = new ReadFile();
        LocalDateTime expectedDate = readFile.extractDate();
        assertThat(expectedDate).isEqualTo(setDate("29/10/2020 14:32"));
    }

    private LocalDateTime setDate(String date){
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd/MM/yyyy HH:mm");
        return LocalDateTime.parse(date, formatter);
    }


}