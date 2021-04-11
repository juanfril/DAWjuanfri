package automation.main;

import java.util.Scanner;

/**
 * Main class to manage the house
 */
public class Main
{
    private static void showMenu()
    {
        System.out.println("\nAUTOMATED HOUSE\n");
        System.out.println("1. Winter mode");
        System.out.println("2. Summer mode");
        System.out.println("3. Cooking mode");
        System.out.println("4. Close everything");
        System.out.println("5. Show status");
        System.out.println("0. Exit");
        System.out.print("\nChoose an option: ");
    }

    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        Management mng = new Management();
        int option;

        do
        {
            showMenu();
            option = sc.nextInt();

            switch(option)
            {
                case 1:
                    mng.winterMode();
                    break;
                case 2:
                    mng.summerMode();
                    break;
                case 3:
                    mng.cookingMode();
                    break;
                case 4:
                    mng.closeEverything();
                    break;
                case 5:
                    mng.showStatus();
                    break;
            }
        } while (option != 0);
    }
}
