package automation.main;
import java.util.Scanner;

public class ShowMenu {
    int option;

    public int menu(){
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
        return option;
    }

    public void choose(){
        switch (option){
            case 1:
                System.out.println("option 1");
                break;
            case 2:
                System.out.println("option 2");
                break;
            case 3:
                System.out.println("option 3");
                break;
            case 4:
                System.out.println("option 4");
                break;
            case 5:
                System.out.println("option 5");
                break;
            case 0:
                System.out.println("Exit");
                break;
            default:
                System.out.println("No correct option");
                break;
        }
    }
}
