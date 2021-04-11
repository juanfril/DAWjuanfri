package com.company;

public class Main{

    public static void main(String[] args) {
        Windows myWindow[] = new Windows[10];

        for (int i = 0; i < myWindow.length; i++){
            myWindow[i] = new Windows();
            myWindow[i].SetWidth((int)Math.floor(Math.random()*(90-120) + 120));
            myWindow[i].SetHeight((int)Math.floor(Math.random()*(40-100) + 100));
        }

        for (Windows i : myWindow){
            System.out.println(i);
        }
    }
}
