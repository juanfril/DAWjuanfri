// Exercise 2.9.1.1

import java.io.*;
import java.util.Scanner;

public class TwoSentences
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);        
        PrintWriter pw = null;
        String sentence;
        
        try
        {
            pw = new PrintWriter("twoSentences.txt");
        
            System.out.println("Write two sentences:");
            sentence = sc.nextLine();
            pw.println(sentence);
            sentence = sc.nextLine();
            pw.println(sentence);
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } finally {        
            pw.close();
        }        
    }
}
