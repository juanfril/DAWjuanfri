/*Juan Fco. Losa Márquez
Program  that asks the user a month name and then it shows the number
of days of this month. You can't use "if" nor "switch" to do this.*/

import java.util.Scanner;

public class exercise7 {
    public static void main(String[] args) throws Exception {
        Scanner sc = new Scanner(System.in);
        String mouth;
        String[] allMouth = {"Janary", "February", "March", "April", "May",
            "June", "July", "August", "September", "October",
            "November", "December"};
        int[] daysMouth = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

        System.out.print("Input a month: ");
        mouth = sc.nextLine();

        sc.close();

        for(int i = 0; i < 12; i++){
            while(allMouth[i].equals(mouth)){
                System.out.println(mouth + " has " + daysMouth[i] + " days");
                break;
            }
        }
    }
}
