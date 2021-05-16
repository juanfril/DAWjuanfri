package race;

import java.io.*;
import java.util.ArrayList;
import java.util.Comparator;

/**
 * Class with useful methods to read/write stages from/to text files
 */

public class FileUtils {

    static final String STATS_FILE = "stats.txt";

    public static ArrayList<CyclingStage> loadStats() {

        ArrayList<CyclingStage> list = new ArrayList<CyclingStage>();

        BufferedReader inputFile;

        if (! (new File(STATS_FILE)).exists() ) {

            System.out.println("File stats.txt not found");
            return list;

        } else {

            System.out.println("Reading file...");
            try {
                inputFile = new BufferedReader(
                        new FileReader("stats.txt"));
                String line;
                do {
                    line = inputFile.readLine();

                    if (line != null) {
                        System.out.println(line);
                        String[] lineSplit = line.split(";");
                        list.add(new CyclingStage(lineSplit[0], Double.parseDouble(lineSplit[1]), lineSplit[2]));
                    }
                } while (line != null);

                inputFile.close();
            } catch (IOException fileError) {
                System.out.println(
                        "There has been some problems: " +
                                fileError.getMessage());
            }

            System.out.println("Reading finished.");
        }

        return list;
    }

    public static void saveStats(ArrayList<CyclingStage> list) {

        PrintWriter printWriter = null;

        try {

            printWriter = new PrintWriter(STATS_FILE);

            list.sort(new Comparator<CyclingStage>() {
                @Override
                public int compare(CyclingStage p1, CyclingStage p2) {
                    return p1.getDateStage().compareTo(p2.getDateStage());
                }
            });

            for (int i = 0; i < list.size(); i++) {
                printWriter.println(list.get(i).getDateStage() + ";" +
                        list.get(i).getTotalNumberKm() + ";" +
                        list.get(i).getWinnerFullName());
            }
        }
        catch (FileNotFoundException e) {
            e.printStackTrace();
        }
        catch (IOException e) {
            e.printStackTrace();
        }
        finally {
            if (printWriter != null) {
                printWriter.close();
            }
        }
    }
}
