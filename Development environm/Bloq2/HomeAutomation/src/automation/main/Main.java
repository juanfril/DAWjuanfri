package automation.main;
import automation.data.*;
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
                case 1:
                    Management.winter();
                    break;
                case 2:
                    Management.summer();
                    break;
                case 3:
                    Management.cooking();
                    break;
                case 4:
                    Management.closeEverything();
                    break;
                case 5:
                    Management.showStatus();
                    break;
                case 0:
                    System.out.println("Exit");
                    break;
                default:
                    System.out.println("No correct option");
                    break;
            }
        }while (option != 0);
    }
}
