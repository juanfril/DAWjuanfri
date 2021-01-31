package com.company;

public class Main {

    public static void main(String[] args) {
        ComplexNumber myNumber1 = new ComplexNumber();
        ComplexNumber myNumber2 = new ComplexNumber();

        myNumber2.setRealNumber(4);
        myNumber2.setImaginaryNumber(-2);

        System.out.println(myNumber1);
        System.out.println(myNumber2);
        System.out.printf("%.2f %n", myNumber1.getMagnitude());
        System.out.printf("%.2f %n", myNumber2.getMagnitude());

        System.out.println(myNumber1.Sum(myNumber1.getRealNumber(),
                myNumber2.getRealNumber(), myNumber1.getImaginaryNumber(),
                myNumber2.getImaginaryNumber()));
    }
}
