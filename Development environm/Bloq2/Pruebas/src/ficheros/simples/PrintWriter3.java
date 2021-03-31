package ficheros.simples;
import java.io.*;

public class PrintWriter3 {
    public static void main(String[] args) {
        PrintWriter printWriter = null;
        try {
            printWriter = new PrintWriter(new BufferedWriter(
                    new FileWriter("example.txt")));
            printWriter.println ("Esto");
            printWriter.println ("tambien...");
            printWriter.println ("se copia!");
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
