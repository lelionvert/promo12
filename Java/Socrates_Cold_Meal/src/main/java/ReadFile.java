import com.opencsv.CSVReader;
import com.opencsv.exceptions.CsvException;
import com.opencsv.exceptions.CsvValidationException;

import java.io.IOException;
import java.io.Reader;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.List;

public class ReadFile {
    public static List<CheckIn> read() throws IOException {
        List<CheckIn> checkin = new ArrayList<>();
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd/MM/yyyy HH:mm");
        try (
                Reader reader = Files.newBufferedReader(Paths.get("D:\\Documents\\IdeaProjects\\promo12\\Java\\Socrates_Cold_Meal\\src\\main\\resources\\Checkins.csv"));
                CSVReader csvReader = new CSVReader(reader)
        ) {
            List<String[]> records = csvReader.readAll();
            // TODO faire un refactor !
            for (String[] record : records) {
                String date = record[0].substring(record[0].indexOf(";")+1);
                checkin.add(new CheckIn(LocalDateTime.parse(date, formatter)));
            }
        } catch (CsvException e) {
            e.printStackTrace();
        }
        return checkin;
    }
}
