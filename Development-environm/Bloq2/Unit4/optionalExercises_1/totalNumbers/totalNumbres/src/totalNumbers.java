/*Juan Fco. Losa Márquez
Program that ask numbers to the user until he types a 0.
Then, it will print the total amount of numbers that the user has typed, 
apart from the last one.*/

import java.util.Scanner;

public class totalNumbers {
    public static void main(String[] args) throws Exception {
        Scanner entrada = new Scanner(System.in);
        int count = 0;
        int input;

        do{
            System.out.print("Input a number: ");
            input = entrada.nextInt();
            count++;
        }
        while(input != 0);

        entrada.close();

        System.out.println("The total amount numbers input is: " + --count);
    }
}
