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

        System.out.println("The total amount numbers input is: " + --count);

        entrada.close();
    }
}
