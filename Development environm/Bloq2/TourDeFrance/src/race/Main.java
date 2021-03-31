package race;

import java.util.Scanner;

public class Main {
    private static void showMenu(){
        System.out.println("\nTour de France\n");
        System.out.println("1. Add stage");
        System.out.println("2. Show winners");
        System.out.println("3. Top winner");
        System.out.println("0. Exit");
        System.out.print("\nChoose an option: ");
    }
    private static void addStage() {

    }
    private static void showWinners() {

    }

    private static void topWinner() {

    }

    public static void main( String[] args ) {
        FileUtils.loadStats();
        Scanner sc = new Scanner(System.in);
        int option;

        showMenu();
        option = sc.nextInt();

        do {
            switch (option){
                case 1:
                    addStage();
                    break;
                case 2:
                    showWinners();
                    break;
                case 3:
                    topWinner();
                    break;
                case 0:
                    System.out.println("Thanks, see you next time!");
                    break;
            }

        }while (option != 0);
    }




}
