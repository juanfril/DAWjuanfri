/**
 * Program that asks the user to enter 4 numbers, stores them in 4
 * strings, and then joins them by pairs and adds the two resulting
 * numbers
 */ 

import java.util.Scanner;

public class NumbersStrings
{
    public static void main(String[] args)
    {
        String numberString1, numberString2,
               numberString3, numberString4;
        
        int number1, number2, result;
        
        Scanner sc = new Scanner(System.in);
        
        System.out.println("Enter 4 numbers:");
        numberString1 = sc.nextLine();
        numberString2 = sc.nextLine();
        numberString3 = sc.nextLine();
        numberString4 = sc.nextLine();
   
		// Join first two numbers
        number1 = Integer.parseInt(numberString1 + numberString2);
        // Join last two numbers
        number2 = Integer.parseInt(numberString3 + numberString4);
        // Add both resulting numbers
        result = number1 + number2;
        
        System.out.println("Result = " + result);
    }
}
