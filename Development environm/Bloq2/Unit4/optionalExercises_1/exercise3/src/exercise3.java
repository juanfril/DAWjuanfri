/*Juan Fco. Losa
    Create a program that prints the prime numbers until a number
    specified by the user*/

import java.util.Scanner;

public class exercise3 {
    public static void main(String[] args) throws Exception {
        Scanner sc = new Scanner(System.in);
        boolean prime = true;

        System.out.print("Input a number: ");
        int input = sc.nextInt();
        sc.close();

        System.out.print("Prime numbers until " + input + " are: 1");

        for(int i = 3; i <= input; i++){
            
            for(int j = 2; j < i && (prime); j++){
                if(i % j == 0)
                    prime = false;
            }
            
            if(prime)
                System.out.print("," + i);
            
            prime = true;
        }
    }
}
    

