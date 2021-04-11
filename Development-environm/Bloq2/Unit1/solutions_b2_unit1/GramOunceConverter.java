/**
 * Program that asks the user to enter a weight in grams, and then it
 * converts it to ounces
 */ 

import java.util.Scanner;

public class GramOunceConverter
{  
	// Constant to convert from grams to ounces (1 ounce = 28.3495 grams)  
    static final float GRAMS_OUNCES = 28.3495f;
    
    public static void main(String[] args)
    {        
        int grams;
        double ounces;
        Scanner sc = new Scanner(System.in);
        
        System.out.println("Enter grams:");
        grams = sc.nextInt();
        ounces = grams / GRAMS_OUNCES;
        // Format the output with 2 decimal digits
        System.out.printf("%d grams are %.2f ounces", grams, ounces);
    }
}
