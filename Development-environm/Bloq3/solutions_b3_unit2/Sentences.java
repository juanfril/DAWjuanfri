// Exercise 2.9.1.2

import java.io.*;
import java.util.Scanner;

public class Sentences
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);        
        PrintWriter pw = null;
        String sentence;
        
        try
        {
            pw = new PrintWriter("sentences.txt");
        
            System.out.println("Write sentences. Empty string to finish:");
            do
            {
                sentence = sc.nextLine();
                if (!sentence.equals(""))
                    pw.println(sentence);
            } while (!sentence.equals(""));
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } finally {        
            pw.close();
        }        
    }
}
