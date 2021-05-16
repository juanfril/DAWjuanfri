package race;

import java.util.*;

/**
 * Main program to manage Tour de France stats
 */

public class Main {

    public static void topWinner(ArrayList<CyclingStage> list) {

        Map<String,Integer> winners = new HashMap<>();
        int maxVictories=1;
        String topWinner=list.get(0).getWinnerFullName();

        for(CyclingStage c: list) {
            if(winners.containsKey((c.getWinnerFullName()))) {
                winners.put(c.getWinnerFullName(), (winners.get(c.getWinnerFullName()) + 1));
                if (maxVictories < (winners.get(c.getWinnerFullName()))) {
                    maxVictories = winners.get(c.getWinnerFullName());
                    topWinner = c.getWinnerFullName();
                }
            } else {
                winners.put(c.getWinnerFullName(),1);
            }
        }

        System.out.println("The Top Winner is.. "+topWinner);
    }

    public static void showWinners(ArrayList<CyclingStage> list) {

            HashSet<String> winners = new HashSet();
            for (CyclingStage c: list)
                winners.add(c.getWinnerFullName());

            System.out.println("The winners are: ");
            for (String name: winners)
                System.out.println(name);
    }

    public static void addStage(ArrayList<CyclingStage> list) {

            String dateStage;
            double totalKm;
            String winner;
            Scanner sc = new Scanner(System.in);

            System.out.println("Enter a date (with the format yyyy-mm-dd,such as 2021-05-21): ");
            dateStage = sc.nextLine();
            System.out.println("Enter the full winner name: ");
            winner = sc.nextLine();
            System.out.println("Enter km: ");
            totalKm = sc.nextDouble();

            CyclingStage newCycle = new CyclingStage(dateStage,totalKm,winner);

            if (!list.contains(newCycle)) {
                list.add(newCycle);
                FileUtils.saveStats(list);
            } else {
                System.out.println("Error: Stage previously introduced");
            }
        }

    public static void main(String[] args) {

        ArrayList<CyclingStage> list = FileUtils.loadStats();
        int option;
        Scanner sc = new Scanner(System.in);
        do{
            System.out.println("Choose an option");
            System.out.println("1. Add stage");
            System.out.println("2. Show winners");
            System.out.println("3. Top winner");
            System.out.println("0. Exit");
            option = sc.nextInt();
            switch (option) {
                case 1: addStage(list);break;
                case 2: showWinners(list); break;
                case 3: topWinner(list);break;
                case 0: break;
                default:  System.out.println("Incorrect option"); break;
            }
        } while (option != 0);
    }
}
