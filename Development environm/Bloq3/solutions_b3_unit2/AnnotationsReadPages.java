// Exercise 2.9.2.3

import java.io.*;
import java.util.Scanner;

public class AnnotationsReadPages
{
    public static void main(String[] args)
    {
        BufferedReader br = null;
        String sentence;
        int lineCount;
        Scanner sc;
        
        sc = new Scanner(System.in);
        
        try
        {
			br = new BufferedReader(new FileReader(
					new File("annotations.txt")));
        	lineCount = 0;
        	
			while((sentence = br.readLine()) != null)
			{
				System.out.println(sentence);
				lineCount++;
				if (lineCount == 23)
				{
					System.out.println("Press enter to go on...");
					sc.nextLine();
					lineCount = 0;
				}
			}
				
        } catch (IOException e) {
            e.printStackTrace();
        } finally { 
			try
			{       
				br.close();
			} catch (Exception e) {}
        }        
    }
}
