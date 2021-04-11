// Exercise 2.9.1.5

import java.io.*;
import java.util.Scanner;

public class Rectangle
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);        
        PrintWriter pw = null;
        int width, height;
        
        System.out.println("Enter rectangle width:");
        width = sc.nextInt();
        System.out.println("Enter rectangle height:");
        height = sc.nextInt();
        
        try
        {
            pw = new PrintWriter("rectangle.txt");
            
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    pw.print("*");
                }
                pw.println();
            }
            
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } finally {        
            pw.close();
        }        
    }
}
