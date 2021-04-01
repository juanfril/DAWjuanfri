// Exercise 2.9.2.1

import java.io.*;

public class TwoSentencesRead
{
    public static void main(String[] args)
    {
        BufferedReader br = null;
        String sentence;
        
        try
        {
			br = new BufferedReader(new FileReader(
					new File("twoSentences.txt")));
        
			sentence = br.readLine();
			System.out.println("First line is:\n" + sentence);
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
