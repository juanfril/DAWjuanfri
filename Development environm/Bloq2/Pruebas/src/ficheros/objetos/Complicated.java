package ficheros.objetos;

import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class Complicated {
    public static ArrayList<Person> load(){
        ArrayList<Person> stats = new ArrayList<>();
        String[] AUX;

        if (! (new File("example.txt")).exists() ) {
            System.out.println("File stats.txt not found");
        }
        else {
            System.out.println("Reading file...");
        }
        try{
            BufferedReader inputFile = new BufferedReader(
                    new FileReader(new File("example.txt")));
            while (inputFile != null){
                AUX = inputFile.readLine().split(";");
                Person p = new Person(AUX[0], AUX[1], AUX[2]);
                stats.add(p);
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
        for (Object p: text) {
            System.out.println(p);
        }

    }

}
