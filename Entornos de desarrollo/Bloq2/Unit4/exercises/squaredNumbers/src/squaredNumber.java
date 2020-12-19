import java.util.Scanner;

public class squaredNumber {
    public static void main(String[] args) throws Exception {
        Scanner entrada = new Scanner(System.in);

        int squared = 1;

        System.out.print("Input a number: ");
        int number = entrada.nextInt();

        for(int i = 0; i < number; i++){
            System.out.print(squared * squared + " ");
            squared++;
        }
        entrada.close();
    }
}
