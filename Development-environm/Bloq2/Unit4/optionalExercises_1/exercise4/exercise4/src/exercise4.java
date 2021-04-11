//Juan Fco. Losa Márquez
/*program that asks the user double numbers until the word “end” is
typed and then it has to print the minimum, the maximum, the addition and
the average in each step.*/

import java.util.Scanner;

public class exercise4 {
    public static void main(String[] args) throws Exception {
        Scanner sc = new Scanner(System.in);
        double num, minimun = 200000, maximun = -200000, addition = 0,
            average;
        int count = 0;
        String exit;

        do{
            System.out.print("Number? ");
            exit = sc.nextLine();
            sc.close();

            if(exit.equals("end"))
                System.out.println("Thanks for use our program!");
            
            else{
                num = Double.parseDouble(exit);
                count++;
                if(num < minimun)
                    minimun = num;
                if(num > maximun)
                    maximun = num;
                addition += num;
                average = addition / count;

                System.out.println("min= " + minimun + " max= " + maximun + 
                " add= " + addition + " avg= " + average);
            }
        }
        while(!exit.equals("end"));
    }
}
