// Exercises 2.9.1.3 and 2.9.1.4

import java.io.*;
import java.util.Scanner;
import java.time.LocalDateTime;

public class SentencesAppend
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);        
        PrintWriter pw = null;
        String sentence;
        
        try
        {
            // We just use a FileWriter to append new content
            pw = new PrintWriter(new BufferedWriter(
                new FileWriter("annotations.txt", true)));
        
            System.out.println("Write sentences. Empty string to finish:");
            do
            {
                sentence = sc.nextLine();
                if (!sentence.equals(""))
                    // pw.println(sentence);
                    // In exercise 4, we add current date and time
                    pw.println(LocalDateTime.now() + ":" + sentence);
            } while (!sentence.equals(""));
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } finally {        
            pw.close();
        }        
    }
}
