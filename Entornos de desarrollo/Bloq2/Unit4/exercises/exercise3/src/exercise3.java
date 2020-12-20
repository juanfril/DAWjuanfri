//not finish

import java.util.Scanner;

public class exercise3 {
    public static void main(String[] args) throws Exception {
        Scanner sc = new Scanner(System.in);

        System.out.print("Input a number: ");
        int input = sc.nextInt();

        System.out.print("Prime numbers until " + input + ": ");

        for(int i = 1; i < input; i++){

            for( int j = 2; j <= input; j++){
                if(i==1){
                    System.out.print("1,");
                }
                else if(i%j != 0)
                    System.out.print(i + ", ");
            }
        }
        
        sc.close();
        
    }
}
