package ficheros.simples;

import java.io.*;

public class BufferedReader1 {
    public static void main( String[] args ) {
// First we check if file exists
        if (! (new File("example.txt")).exists() ) {
            System.out.println("File example.txt not found");
            return;
        }
// If it exists, we try to read it
        System.out.println("Reading file...");
        try {
            BufferedReader inputFile = new BufferedReader(
                    new FileReader(new File("example.txt")));
            String line = inputFile.readLine();
            while (line != null) {
                System.out.println(line);
                line = inputFile.readLine();
            }
            inputFile.close();
        }
        catch (IOException fileError) {
            System.out.println(
                    "There has been some problems: " +
                            fileError.getMessage() );
        }
        System.out.println("Reading finished.");
    }
}
