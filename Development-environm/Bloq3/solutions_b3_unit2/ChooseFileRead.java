// Exercise 2.9.2.4

import java.io.*;
import java.util.Scanner;

public class ChooseFileRead
{
    public static void main(String[] args)
    {
        BufferedReader br = null;
        String sentence, fileName;
        Scanner sc = new Scanner(System.in);
        
        System.out.println("Enter a file name to read:");
        fileName = sc.nextLine();
        
        try
        {			
			br = new BufferedReader(new FileReader(
					new File(fileName)));
        			
			while((sentence = br.readLine()) != null)
				System.out.println(sentence);
				
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
