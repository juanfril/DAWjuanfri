/*Juan Fco. Losa Márquez
Program that prints the first n squared numbers, 
asking to the user the number n*/

import java.util.Scanner;

public class squaredNumber {
    public static void main(String[] args) throws Exception {
        Scanner entrada = new Scanner(System.in);
        int squared = 1;

        System.out.print("Input a number: ");
        int number = entrada.nextInt();
        entrada.close();

        for(int i = 0; i < number; i++){
            System.out.print(squared * squared + " ");
            squared++;
        }
    }
}
