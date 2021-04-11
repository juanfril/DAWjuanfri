package com.company;

public class ComplexNumber {
    protected int realNumber, imaginaryNumber;

    public int getRealNumber(){ return realNumber; }
    public int getImaginaryNumber(){ return imaginaryNumber; }

    public void setRealNumber(int realNumber){
        this.realNumber = realNumber;
    }
    public void setImaginaryNumber(int imaginaryNumber){
        this.imaginaryNumber = imaginaryNumber;
    }

    public ComplexNumber(){
        realNumber = 2;
        imaginaryNumber = -3;
    }
    public String toString(){
        return String.valueOf(realNumber) +
                String.valueOf(imaginaryNumber) + "i";
    }
    public double getMagnitude(){
        double magnitude = Math.sqrt((Math.pow(realNumber, 2) +
                Math.pow(imaginaryNumber, 2)));
        return magnitude;
    }
    public static String Sum(int a1, int a2, int b1, int b2){
        int a = a1 + a2;
        int b = b1 + b2;
        return String.valueOf(a) + String.valueOf(b) + "i";
    }
}
