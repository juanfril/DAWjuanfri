// Exercise 2.9.2.2

import java.io.*;

public class AnnotationsRead
{
    public static void main(String[] args)
    {
        BufferedReader br = null;
        String sentence;
        
        try
        {
			br = new BufferedReader(new FileReader(
					new File("annotations.txt")));
        			
			while((sentence = br.readLine()) != null)
				System.out.println(sentence);
				
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
