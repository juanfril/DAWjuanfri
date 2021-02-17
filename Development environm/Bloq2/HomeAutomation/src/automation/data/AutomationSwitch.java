package automation.data;

public abstract class AutomationSwitch {

    boolean switchHow;
    String nameSwitch;

    public AutomationSwitch(String name){
        this.nameSwitch = name;
    }

    public String getNameSwitch() { return nameSwitch; }

    public void setNameSwitch(String name) { this.nameSwitch = name; }

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
        return "- " + nameSwitch + ": " + getStatus();
    }
}
