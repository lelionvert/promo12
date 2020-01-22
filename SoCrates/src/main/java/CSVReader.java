import sun.reflect.generics.reflectiveObjects.NotImplementedException;

import java.io.*;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

public class CSVReader implements IReader {


    public static List<String> readFile(String pathName){

        BufferedReader reader = null;
        String line = "";
        List<String> fileContents = new ArrayList<>();
        try {

            reader = new BufferedReader(new FileReader(pathName));
            while ((line = reader.readLine()) != null) {

                fileContents.add(line);
            }

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } finally {
            if (reader != null) {
                try {
                    reader.close();
                } catch (IOException e) {
                    e.printStackTrace();
                }
            }
        }
        return fileContents;
    }

    public List<Booking> MapToBooking(List<String> filecontents)
    {
        List<Booking> bookings = new ArrayList<>();
        bookings = filecontents.stream().map(Booking::of).collect(Collectors.toList());

        return bookings;
    }

    @Override
    public List<Booking> getBookings() {
        throw new NotImplementedException();
    }
}
