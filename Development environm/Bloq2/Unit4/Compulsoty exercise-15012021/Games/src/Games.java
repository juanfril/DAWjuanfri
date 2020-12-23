/*Juan Fco. Losa Márquez
--Compulsoty exercise--
Two games for play in console. A lottery game, and a play versus
machine that substratc chip to pending 0*/

import java.util.Arrays;
import java.util.Scanner;

public class Games {
    public static void main(String[] args){

        if(args[0].equals("lottery"))
            playLottery();

        if(isNumeric(args[1]) == false)
            System.out.println("Is not a number");

        if(args[0].equals("Nim") && isNumeric(args[1]))
            playNim(Integer.parseInt(args[1]));
        
    }

    public static boolean isNumeric(String args){

        try{
            Integer.parseInt(args);
            return true;
        }
        catch(NumberFormatException exception){
            return false;
        }
    }

    public static int generateNumber(int min, int max){

        return (int)Math.floor(Math.random()*(min-max) + max);
    }

    public static int[] generateLottery(){

        int[] sixNumbers = new int[6];

        for(int i = 0; i < 6; i++){
            sixNumbers[i] = generateNumber(1 , 50);
            
            for(int j = i; j >= i; j--){

                do{

                    if(sixNumbers[i] == sixNumbers[j])
                        sixNumbers[j] = generateNumber(1 , 50);

                }
                while(sixNumbers[i] == sixNumbers[j] && sixNumbers.length < 1);
            }
        }
        Arrays.sort(sixNumbers);

        return sixNumbers;
    }

    public static int checkLottery(int[] user, int[] winner){

        int count = 0;

        for(int i = 0; i < 6; i++)
            if(user[i] == winner[i])
                count++;

        return count;
    }
    
    public static void playNim(int number){

        Scanner sc = new Scanner(System.in);
        int choose;

        System.out.printf("Playing Nim with %d chips.%n", number);

        while(number > 1){

            System.out.println("Your turn. Choose how many chips to substract:");
            choose = sc.nextInt();
            number -= choose;

            if(number == 1){

                System.out.printf("%d chips pending %n", number);
                System.out.println("YOU WIN");
            }

            else if(number == 0)
                System.out.println("YOU LOOSE");

            else{

                System.out.printf("%d chips pending %n", number);

                choose = generateNumber(1, 4);
                System.out.printf("Computer substracts %d chips.%n", choose);
                number -= choose;
    
                if(number == 1)
                    System.out.println("YOU LOOSE");

                else if(number == 0)
                    System.out.println("YOU WIN");
    
                else
                    System.out.printf("%d chips pending %n", number);
            }
        }
        
        sc.close();
    }

    public static void playLottery(){

        Scanner sc = new Scanner(System.in);
        int[] user = new int[6];
        int[] winner = generateLottery();

        System.out.println("Enter your combination:");

        for(int i = 0; i < 6; i++)
            user[i] = sc.nextInt();
        sc.close();

        System.out.println("This is the winner combination:");

        for(int i : winner)
            System.out.print(i + " ");

        System.out.println();
        
        System.out.printf("You have %d hits.%n", checkLottery(user, winner));
    }
}
