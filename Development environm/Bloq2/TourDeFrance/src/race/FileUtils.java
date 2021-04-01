package race;

import java.io.*;
import java.util.ArrayList;

public class FileUtils {
    public static ArrayList loadStats(){
        ArrayList<CyclingStage> stats = new ArrayList<>();
        String[] AUX = new String[2];
        byte line = 0;

        if (! (new File("stats.txt")).exists() ) {
            System.out.println("File stats.txt not found");
        }

        try{
            BufferedReader countFiles = new BufferedReader(
                    new FileReader("stats.txt"));

            int numLines = ( int ) countFiles.lines().count();
            System.out.println(numLines);
            countFiles.close();

            BufferedReader inputFile = new BufferedReader(
                    new FileReader("stats.txt"));

            while(numLines > 0) {

                AUX = inputFile.readLine().split(";");
                stats.add(new CyclingStage());
                if(stats.get(line) instanceof CyclingStage){
                    CyclingStage c = (CyclingStage)(stats.get(line));
                    c.setDate(AUX[0]);
                    c.setKilometres(AUX[1]);
                    c.setWinner(AUX[2]);
                    line++;
                }
                numLines--;
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

    public static void saveStats( ArrayList<CyclingStage> stats ){
        PrintWriter printerWriter = null;
        try{
            printerWriter = new PrintWriter(new BufferedWriter(
                    new FileWriter("stats.txt")));
            for (int i = 0; i < stats.size(); i++) {
                printerWriter.println(stats.get(i).getDate() + ";" +
                        stats.get(i).getKilometres() + ";" + stats.get(i).getWinner());
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
