package automation.data;

public class Light implements AutomationElement{

    String name;
    boolean switchHow;

    public Light(String name) { this.name = name; }

    @Override
    public String getName() { return name; }

    @Override
    public void setName(String a) { this.name = name; }

    public void switchOn(){ switchHow = true; }

    public void switchOff(){ switchHow = false; }

    @Override
    public String getStatus() {
        if(switchHow)
            return "Switched on";
        else
            return "Switched off";
    }

    @Override
    public String toString(){
        return "- " + name + ": " + getStatus();
    }
}
