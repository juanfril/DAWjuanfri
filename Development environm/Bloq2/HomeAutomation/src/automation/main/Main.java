package automation.main;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        int option;
        Scanner sc = new Scanner(System.in);
        Management home = new Management();

        do{
            System.out.println("Choose option.");
            System.out.println("1. Winter mode");
            System.out.println("2. Summer mode");
            System.out.println("3. Cooking mode");
            System.out.println("4. Close everything");
            System.out.println("5. Show status");
            System.out.println("0. Exit program");

            option = sc.nextInt();

            switch (option) {
                case 1 -> home.winter();
                case 2 -> home.summer();
                case 3 -> home.cooking();
                case 4 -> home.closeEverything();
                case 5 -> home.showStatus();
                case 0 -> System.out.println("Exit");
                default -> System.out.println("No correct option");
            }
        }while (option != 0);
        sc.close();
    }
}
