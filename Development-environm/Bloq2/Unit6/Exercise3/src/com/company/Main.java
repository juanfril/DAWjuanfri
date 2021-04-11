package com.company;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	// write your code here
        ThreeDPoint coordinates[] = new ThreeDPoint[5];
        Scanner sc = new Scanner(System.in);
        int x, y, z;
        double result;

        for (int i = 0; i < coordinates.length; i++) {
            coordinates[i] = new ThreeDPoint();
            System.out.print("Insert 3 coordinates (x y z): ");
            x = sc.nextInt();
            y = sc.nextInt();
            z = sc.nextInt();
            coordinates[i].moveTo(x, y, z);
        }
        sc.close();

        for (ThreeDPoint p: coordinates){
            System.out.println(p);
        }

        for (int i = 0; i < coordinates.length - 1; i++) {
            result = ThreeDPoint.distanceTo(coordinates[i], coordinates[i + 1]);
            System.out.println("The distance between (" + coordinates[i].x +
            ", " + coordinates[i].y + ", " + coordinates[i].z + ") to (" +
                    coordinates[i + 1].x + ", " + coordinates[i + 1].y +
                    ", " + coordinates[i + 1].z + ") is :" + result);
        }
    }
}
