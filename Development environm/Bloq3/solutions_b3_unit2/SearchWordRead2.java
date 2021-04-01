// Exercise 2.9.2.8

import java.io.*;
import java.util.*;

public class SearchWordRead2
{
    public static void main(String[] args)
    {
        BufferedReader br = null;
        String sentence, fileName, word;
        Scanner sc = new Scanner(System.in);
        List<String>sentences = new ArrayList<>();
        boolean found;
        
        System.out.println("Enter a file name to read:");
        fileName = sc.nextLine();
        
        try
        {			
			br = new BufferedReader(new FileReader(
					new File(fileName)));
        			
			while((sentence = br.readLine()) != null)
				sentences.add(sentence);
			
			do
			{
				System.out.println("Enter a word to search:");
				word = sc.nextLine();
				
				if (!word.equals(""))
				{
					found = false;
					for(int i = 0; i < sentences.size(); i++)
					{
						if (sentences.get(i).contains(word))
						{
							found = true;
							System.out.println("Line " + (i+1) + ": " + sentences.get(i));
						}
					}
					
					if (!found)
						System.out.println("Not found");
				}
			} while (!word.equals(""));
				
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
