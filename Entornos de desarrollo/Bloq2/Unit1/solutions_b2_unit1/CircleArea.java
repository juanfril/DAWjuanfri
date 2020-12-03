/**
 * Program that asks the user to enter the radius of a circle, and
 * then it calculates the area of this circle, printing it with 2
 * decimal digits
 */ 

import java.util.Scanner;

public class CircleArea
{
	// Constant to store a value of PI
    static final float PI = 3.14159f;
    
    public static void main(String[] args)
    {
        float radius, area;
        
        Scanner sc = new Scanner(System.in);
        
        System.out.println("Enter circle radius:");
        radius = sc.nextFloat();
        
        area = PI * radius * radius;
        
        System.out.printf("Area = %.2f", area);
        
    }
}
