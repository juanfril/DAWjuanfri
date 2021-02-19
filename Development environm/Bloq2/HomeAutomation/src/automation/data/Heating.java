package automation.data;

public class Heating implements AutomationElement{

    int temperature;
    boolean switchHow;
    String name;

    public Heating(String name){
        this.name = name;
        switchHow = false;
    }

    @Override
    public String getName() { return name; }

    @Override
    public void setName(String name) { this.name = name; }

    @Override
    public int getNumber(){ return temperature; }

    @Override
    public void setNumber(int temperature) {
        this.temperature = temperature;
    }

    @Override
    public void on(){ switchHow = true; }

    @Override
    public void off(){ switchHow = false; }

    @Override
    public String getStatus(){
        if(switchHow)
            return "Switched on";
        else
            return "Switched off";
    }

    @Override
    public void lower(){}

    @Override
    public void lower(int down){}

    @Override
    public void raise(){}

    @Override
    public void raise(int up){}
    ;
    @Override
    public String toString(){
        return "- " + name + ": " + getStatus() +
                ", " + temperature + "ºC";
    }
}
