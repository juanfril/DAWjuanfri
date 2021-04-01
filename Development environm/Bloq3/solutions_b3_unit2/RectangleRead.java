// Exercise 2.9.2.7

import java.io.*;

public class RectangleRead
{
    public static void main(String[] args)
    {
        BufferedReader br = null;
        String sentence;
        int width, height;
        
        try
        {
			br = new BufferedReader(new FileReader(
					new File("rectangle.txt")));
        	
        	width = height = 0;
        			
			while((sentence = br.readLine()) != null)
			{
				if (width == 0)
					width = sentence.length();
				height++;
			}

			System.out.println("Width = " + width + ", Height = " + height);
				
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
