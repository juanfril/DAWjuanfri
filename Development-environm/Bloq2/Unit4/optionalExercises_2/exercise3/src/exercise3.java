/*Juan Fco. Losa Márquez
Program thar ask user 10 number and split odd numbers
and even numbers*/

import java.util.Scanner;

public class exercise3 {

    public static void main(String[] args) throws Exception {
        final int MAX = 10;
        int[] number = new int[MAX];

        askNumbers(MAX, number);

        int[] even = splitEven(number);
        int[] odd = splitOdd(number);

        show(even);

        System.out.println();

        show(odd);
    }

    static void askNumbers(final int MAX, int[] number){
        Scanner sc = new Scanner(System.in);

        for(int i = 0; i < MAX; i++){
            System.out.println("Input a number: ");
            number[i] = sc.nextInt();
        }
        sc.close();
    }

    static int[] splitEven(int[] number){
        int countEven = 0;
        int countArray = 0;
        int[] even;

        for(int i = 0; i < number.length - 1; i++){
            if(number[i] % 2 != 0){
                countArray++;
            }
        }
        even = new int[countArray];
        
        for(int i = 0; i < number.length - 1; i++){
            if(number[i] % 2 != 0){
                even[countEven] = i;
                countEven++;
            }
        }
        return even;
    }

    static int[] splitOdd(int[] number){
        int countArray = 0;
        int countOdd = 0;
        int[] odd;

        for(int i = 0; i < number.length - 1; i++){
            if(number[i] % 2 == 0){
                countArray++;
            }
        }
        odd = new int[countArray];

        for(int i = 0; i < number.length - 1; i++){
            if(number[i] % 2 == 0){
                odd[countOdd] = i;
                countOdd++;
            }
        }
        return odd;
    }

    static void show(int[] show){
        for(int i: show)
            System.out.print("-" + i);
    }
}
