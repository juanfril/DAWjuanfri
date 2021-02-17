package automation.data;

public class Heating extends AutomationSwitch{
    int temperature;

    public Heating(String name) {
        super(name);
    }

    public String getTemperature(){ return temperature + "ºC"; }

    public void setTemperature(int temperature) {
        this.temperature = temperature;
    }
    public Heating(){}

    public Heating(int temperature){
        this.temperature = temperature;
    }
    public Heating(int temperature, boolean switchHow){
        this.temperature = temperature;
        this.switchHow = switchHow;
    }

    @Override
    public String toString(){
        return super.toString() + ", " + temperature + "ºC";
    }
}
