package house.main;

public class House {
    private int area;
    Door door;

    public House(){
        area = 0;
        door = new Door();
    }

    public int getArea() {
        return area;
    }

    public void setArea(int area) {
        this.area = area;
    }

    @Override
    public String toString(){
        return "I'm a house, and my area is " + area + " m2";
    }

}
