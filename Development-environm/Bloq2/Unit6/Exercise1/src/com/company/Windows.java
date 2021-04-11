package com.company;

public class Windows {
    String name;
    int width;
    int height;

    /*public String GetName(){return name;}
    public int GetWidth(){return width;}
    public int GetHeight(){return height;}

    public void SetName(String n){name = n;}*/
    public void SetWidth(int w){width = w;}
    public void SetHeight(int h){height = h;}

    public Windows(){
        name = "\"Standard\"";
        width = 160;
        height = 180;
    }

    public String toString(){
        return  name + " window type measures " +
                width + " x " + height + " cm";
    }
}
