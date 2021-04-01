// Exercise 2.9.2.5

import java.io.*;
import java.util.Scanner;

public class UpperCaseRead
{
    public static void main(String[] args)
    {
        BufferedReader br = null;
        PrintWriter pw = null;
        String sentence, fileName;
        Scanner sc = new Scanner(System.in);
        
        System.out.println("Enter a file name to read:");
        fileName = sc.nextLine();
        
        try
        {			
			br = new BufferedReader(new FileReader(
					new File(fileName)));
			pw = new PrintWriter("uppercase_" + fileName);
        			
			while((sentence = br.readLine()) != null)
				pw.println(sentence.toUpperCase());
				
        } catch (FileNotFoundException e) {
			System.err.println("Error. File not found");
        } catch (IOException e) {
            e.printStackTrace();
        } finally { 
			try
			{       
				br.close();
				pw.close();
			} catch (Exception e) {}
        }        
    }
}
