package com.company;

public class ThreeDPoint {
    protected int x, y, z;

    public int GetX(){return x; }
    public int GetY(){return y; }
    public int GetZ(){return z; }

    public void SetX(int x){ this.x = x; }
    public void SetY(int y){ this.y = y; }
    public void SetZ(int z){ this.z = z; }

    public ThreeDPoint(){
        x = 10;
        y = 10;
        z = 10;
    }

    public void moveTo(int x, int y, int z){
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public static double distanceTo(ThreeDPoint p1, ThreeDPoint p2){
        double result;
        ThreeDPoint threeDPoint1 = p1;
        ThreeDPoint threeDPoint2 = p2;

        result = Math.sqrt(Math.pow((threeDPoint1.x - threeDPoint2.x), 2) +
                Math.pow((threeDPoint1.y - threeDPoint2.y), 2) +
                Math.pow((threeDPoint1.z - threeDPoint2.z), 2));

        return result;
    }

    public String toString(){
        return "The coordinates are " + x + ", "
                + y + ", " + z;
    }
}
