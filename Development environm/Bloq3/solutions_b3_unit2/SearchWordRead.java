// Exercise 2.9.2.6

import java.io.*;
import java.util.*;

public class SearchWordRead
{
    public static void main(String[] args)
    {
        BufferedReader br = null;
        String sentence, fileName, word;
        Scanner sc = new Scanner(System.in);
        int i = 0;
        
        System.out.println("Enter a file name to read:");
        fileName = sc.nextLine();
        
		System.out.println("Enter a word to search:");
		word = sc.nextLine();

        try
        {			
			br = new BufferedReader(new FileReader(
					new File(fileName)));
        			
			while((sentence = br.readLine()) != null)
			{
				i++;
				if (sentence.contains(word))
					System.out.println("Line " + i + ": " + sentence);				
			}
				
        } catch (FileNotFoundException e) {
			System.err.println("Error. File not found");
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
