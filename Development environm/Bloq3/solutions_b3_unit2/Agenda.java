// Exercise 2.9.1.6

import java.io.*;
import java.util.Scanner;

public class Agenda
{
    public static void main(String[] args)
    {
        String[] dayNames = {"Monday", "Tuesday", "Wednesday",
                              "Thursday", "Friday", "Saturday", "Sunday"};

        Scanner sc = new Scanner(System.in);        
        PrintWriter pw = null;
        String monthName;
        int monthDays, startingDay, weekIndex;
        
        System.out.println("Month name:");
        monthName = sc.nextLine();
        System.out.println("Days of the month:");
        monthDays = sc.nextInt();
        System.out.println("Starting day:");
        startingDay = sc.nextInt();
        
        startingDay--;   
        weekIndex = startingDay;     
        
        try
        {
            pw = new PrintWriter(monthName + ".txt");        
            
            pw.println(monthName + "\n");
            pw.println("-----------------------------------------------------------");
            
            for(int i = 1; i <= monthDays; i++)
            {
                pw.println(dayNames[weekIndex] + " " + i + ":");
                pw.println("-----------------------------------------------------------");                
                weekIndex = (weekIndex + 1) % dayNames.length;
            }
            
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } finally {        
            pw.close();
        }        
    }
}
