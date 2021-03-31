package race;

import java.io.*;
import java.util.ArrayList;

public class FileUtils {
    public static ArrayList loadStats(){
        ArrayList stats = new ArrayList();
        ArrayList temporal = new ArrayList();
        String line;

        if (! (new File("stats.txt")).exists() ) {
            System.out.println("File stats.txt not found");
        }
        else {
            System.out.println("Reading file...");
        }
        try{
            BufferedReader inputFile = new BufferedReader(
                    new FileReader(new File("stats.txt")));
            line = inputFile.readLine();

            while(line != null) {
                temporal.add(inputFile.readLine().split(";"));
                stats.add(new CyclingStage((String)temporal.get(0),
                        (String)temporal.get(1), (int)temporal.get(2)));
                line = inputFile.readLine();
            }
            inputFile.close();
        }
        catch (IOException fileError) {
            System.out.println(
                    "There has been some problems: " +
                            fileError.getMessage() );
        }
        return stats;
    }

    public static void saveStats( ArrayList stats ){
        PrintWriter printerWriter = null;
        try{
            printerWriter = new PrintWriter(new BufferedWriter(
                    new FileWriter("stats.txt", true)));
            for (int i = 0; i < stats.size(); i++) {
                printerWriter.println(stats.get(i));
            }
        }
        catch (IOException e){
            e.printStackTrace();
        }
        finally {
            if (printerWriter != null){
                printerWriter.close();
            }
        }
    }
}
