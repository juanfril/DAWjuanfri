package automation.main;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        int option;
        do{
            Management[] home = new Management[9];

            Scanner sc = new Scanner(System.in);
            System.out.println("Choose option.");
            System.out.println("1. Winter mode");
            System.out.println("2. Summer mode");
            System.out.println("3. Cooking mode");
            System.out.println("4. Close everything");
            System.out.println("5. Show status");
            System.out.println("0. Exit program");

            option = sc.nextInt();
            sc.close();

            switch (option) {
                case 1 -> Management.winter();
                case 2 -> Management.summer();
                case 3 -> Management.cooking();
                case 4 -> Management.closeEverything();
                case 5 -> Management.showStatus();
                case 0 -> System.out.println("Exit");
                default -> System.out.println("No correct option");
            }
        }while (option != 0);
    }
}
