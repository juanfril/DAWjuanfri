package ficheros.objetos;

import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class Complicated {
    public static ArrayList<Person> load(){
        ArrayList<Person> stats = new ArrayList<>();
        String[] temporal;
        String line;

        if (! (new File("example.txt")).exists() ) {
            System.out.println("File stats.txt not found");
        }
        else {
            System.out.println("Reading file...");
        }
        try{
            BufferedReader inputFile = new BufferedReader(
                    new FileReader(new File("example.txt")));
            line = inputFile.readLine();
            System.out.println(line);
                temporal = inputFile.readLine().split(";");
                for(Object s: temporal){
                    System.out.println(s);
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

    public static void save(ArrayList stats){
        PrintWriter printerWriter = null;
        try{
            printerWriter = new PrintWriter(new BufferedWriter(
                    new FileWriter("example.txt")));
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

    public static void main( String[] args ) {
        ArrayList text = load();


    }

}
