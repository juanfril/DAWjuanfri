/**
 * Exercise that asks the user to enter a day, month and year of birth
 * and then it prints the date with the format d/m/y
 */ 

import java.util.Scanner;

public class FormattedDate
{
    public static void main(String[] args)
    {
        int day, month, year;
        Scanner sc;
        
        sc = new Scanner(System.in);
        
        System.out.println("Enter you day of birth");
        day = sc.nextInt();
        System.out.println("Enter you month of birth");
        month = sc.nextInt();
        System.out.println("Enter you year of birth");
        year = sc.nextInt();
        
        System.out.println(day + "/" + month + "/" + year);
        
        sc.close();
    }
}
