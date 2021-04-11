/*Juan Fco. Losa Márquez
Program that asks the user how many marks is going to introduce.
Then ask the user these marks (double) and store them in an array. The
program has to calculate the average of these marks. After this, the program
must show the marks which are greater than the average mark.*/

import java.util.Arrays;
import java.util.Scanner;

public class exercise5 {
    public static void main(String[] args) throws Exception {
        Scanner sc = new Scanner(System.in);
        int maxArray;
        double suma = 0, average;
        double[] numbers;

        System.out.print("How many marks are going to introduce? ");
        maxArray = sc.nextInt();
        numbers = new double[maxArray];
        sc.close();

        for(int i = 0; i < maxArray; i++){
            numbers[i] = sc.nextDouble();
            suma += numbers[i];
        }

        Arrays.sort(numbers);
        average = suma / (maxArray);

        System.out.print("The average is: " + average + 
        " the greater than the average are: " + numbers[--maxArray]);
    }
}
