package race;

import java.util.ArrayList;
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
    private static void addStage(ArrayList<CyclingStage> stats) {
        Scanner sc = new Scanner(System.in);
        CyclingStage c = new CyclingStage();
        boolean exist = false;

        System.out.println("Input date of the stage (YYYY-MM-DD): ");
        c.setDate(sc.nextLine());
        System.out.println("Input kilometres of race: ");
        c.setKilometres(sc.nextLine());
        System.out.println("Input full name of the winner: ");
        c.setWinner(sc.nextLine());
        for (int i = 0; i < stats.size() || exist; i++) {
            if(c.getDate().equals(stats.get(i).getDate()))
                exist = true;
        }
        if(!exist){
            stats.add(c);
            FileUtils.saveStats(stats);
            System.out.println("\nFile save!");
        }
        else {
            System.out.println("\nSorry, you can't repeat the date. Try again!");
        }

    }
    private static void showWinners(ArrayList<CyclingStage> stats) {
        if(stats.size() == 0){
            System.out.println("\nNo dates yet, try input someone");
        }
        else {
            System.out.println(stats.get(0));
            for (int i = 1; i < stats.size(); i++) {
                if(!stats.get(i-1).getWinner().equals(stats.get(i).getWinner())){
                    System.out.println(stats.get(i));
                }
            }
        }
    }

    private static void topWinner(ArrayList<CyclingStage> stats) {
        int temporalWinner;
        int maxWinner = 0;
        String nameWinner = "";

        if(stats.size() == 0){
            System.out.println("\nNo dates yet, try input someone");
        }
        else {
            for (int i = 0; i < stats.size(); i++) {
                temporalWinner = 0;
                for (int j = 0; j < stats.size(); j++) {
                    if(stats.get(i).getWinner().equals(stats.get(j).getWinner())){
                        temporalWinner++;
                    }
                }
                if (temporalWinner > maxWinner){
                    maxWinner = temporalWinner;
                    nameWinner = stats.get(i).getWinner();
                }
            }
            for(CyclingStage c : stats){
                if(c.getWinner().equals(nameWinner))
                    System.out.println(c);
            }
        }
    }

    public static void main( String[] args ) {
        ArrayList<CyclingStage> stats = FileUtils.loadStats();

        Scanner sc = new Scanner(System.in);
        int option;


        do {
            showMenu();
            option = sc.nextInt();
            switch (option){
                case 1:
                    addStage(stats);
                    break;
                case 2:
                    showWinners(stats);
                    break;
                case 3:
                    topWinner(stats);
                    break;
                case 0:
                    System.out.println("Thanks, see you next time!");
                    break;
            }

        }while (option != 0);
    }
}
