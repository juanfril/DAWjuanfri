// Exercise 2.9.1.7

import java.io.*;
import java.util.Scanner;

public class Calendar
{
    public static void main(String[] args)
    {
        String[] dayNames = {"mon", "tue", "wed",
                              "thu", "fri", "sat", "sun"};

        Scanner sc = new Scanner(System.in);        
        PrintWriter pw = null;
        String monthName;
        int monthDays, startingDay, currentDay;
        
        System.out.println("Month name:");
        monthName = sc.nextLine();
        System.out.println("Days of the month:");
        monthDays = sc.nextInt();
        System.out.println("Starting day:");
        startingDay = sc.nextInt();
        
        startingDay--;   
        currentDay = startingDay;     
        
        try
        {
            pw = new PrintWriter(monthName + "Calendar.txt");        
            
            // Month name
            pw.println(monthName + "\n");
            
            // Day names
            for (String day: dayNames)
				pw.print(day + " ");
			pw.println("\n");
			
			// Initial whitespaces until first day
			for (int i = 0; i < startingDay; i++)
				pw.print("    ");
            
            for(int i = 1; i <= monthDays; i++)
            {
				pw.printf(" %02d ", i);
				currentDay++;
				if (currentDay % 7 == 0)
				{
					pw.println();
					currentDay = 0;
				}
            }
            
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } finally {        
            pw.close();
        }        
    }
}
