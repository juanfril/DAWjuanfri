package museum.main;
import java.util.Scanner;
import java.util.stream.IntStream;

public class Main {

    public static void main(String[] args) {

        int option;
        int count = 0;
        Artworks[] artwork = new Artworks[10];
        Scanner sc = new Scanner(System.in);

        do{
            System.out.println("What artwork you want save?");
            System.out.println("1. Paintings");
            System.out.println("2. Sculptures");
            System.out.println("3. Print artworks");
            System.out.println("0. Exit");

            option = sc.nextInt();

            switch (option){
                case 1:
                    artwork[count] = new Paintings();

                    System.out.println("Insert name of the paint");
                    artwork[count].setName(sc.next());

                    System.out.println("Insert author");
                    artwork[count].setAuthor(sc.next());

                    System.out.println("Insert name of the owner");
                    artwork[count].setOwner(sc.next());

                    System.out.println("Insert made year");
                    artwork[count].setYear(sc.nextInt());

                    count++;
                    break;
                case 2:
                    artwork[count] = new Sculptures();

                    System.out.println("Insert name of the sculpture");
                    artwork[count].setName(sc.next());

                    System.out.println("Insert author");
                    artwork[count].setAuthor(sc.next());

                    System.out.println("Insert name of the owner");
                    artwork[count].setOwner(sc.next());

                    System.out.println("Insert made material");
                    ((Sculptures)artwork[count]).setMaterial(sc.next());

                    System.out.println("Insert made year");
                    artwork[count].setYear(sc.nextInt());

                    count++;
                    break;
                case 3:
                    for (int i = 0; i < count; i++) {
                        System.out.println(artwork[i]);
                    }
                    break;
                case 0:
                    System.out.println("Bye");
                    break;
                default:
                    System.out.println("Incorrect option");
                    break;
            }


        }while(option != 0);
        sc.close();
    }
}
