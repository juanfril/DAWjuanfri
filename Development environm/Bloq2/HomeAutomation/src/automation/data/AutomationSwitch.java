package automation.data;

public abstract class AutomationSwitch {

    boolean switchHow;
    String name;

    public AutomationSwitch(String name){
        this.name = name;
    }

    public String getNameSwitch() { return name; }

    public void setNameSwitch(String name) { this.name = name; }

    public void switchOn(){
        switchHow = true;
    }
    public void switchOff(){
        switchHow = false;
    }
    public String getStatus(){
        if(switchHow)
            return "Switched on";
        else
            return "Switched off";
    }

    public AutomationSwitch(){
        switchHow = false;
    }
    @Override
    public String toString(){
        return "- " + name + ": " + getStatus();
    }
}
