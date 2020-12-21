/*Juan Fco. Losa Márquez
Ask the names of the students at the
same time than their marks. You have to store the names in an array and the
marks in another array and the link between them are the indexes, that is, the
student in the first position corresponds to the first mark, the second to the
second and so on. After storing these names and marks, the program must
show the name of the students with marks greater than the average and the
name of the student with the greatest mark.*/

import java.util.Scanner;

public class exercise6 {
    public static void main(String[] args) throws Exception {
        Scanner sc = new Scanner(System.in);
        int maxArray;
        double suma = 0, average;
        double[] numbers;
        double[] tempNumbers;
        String[] names;
        String[] tempNames;

        System.out.print("How many marks are going to introduce? ");
        maxArray = sc.nextInt();
        numbers = new double[maxArray];
        tempNumbers = new double[maxArray];
        names = new String[maxArray];
        tempNames = new String[maxArray];

        for(int i = 0; i < maxArray; i++){
            names[i] = sc.next();
            numbers[i] = sc.nextDouble();
            suma += numbers[i];
        }
        sc.close();

        average = suma / (maxArray);

        System.out.println("The average is: " + average);
        System.out.println("The students with marks greater than" +
         " the average are: ");

        for (int i = 0; i < maxArray; i++){
            if(average < numbers[i])
                System.out.println("- " + names[i]);
        }

        for (int i = 0; i < maxArray; i++){
            for ( int j = 1; j < maxArray; j++){
                if (numbers[j] > numbers[i]){
                    tempNames[i] = names[j];
                    names[j] = names[i];
                    names[i] = tempNames[i];
                    tempNumbers[i] = numbers[j];
                    numbers[j] = numbers[i];
                    numbers[i] = tempNumbers[i];
                }
            }
        }

        System.out.print("The student with the greatest mark is: " + 
        names[0]);
    }
}
