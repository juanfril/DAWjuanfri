package house.main;

public class Door {
    private String door;
    private String color;

    public Door(){
        color = "Wood";
    }

    public String getColor() {
        return color;
    }

    public void setColor(String color) {
        this.color = color;
    }

    public String getDoor() {
        return door;
    }

    @Override
    public String toString(){
        return "I'm a door, my color is " + color;
    }

}
