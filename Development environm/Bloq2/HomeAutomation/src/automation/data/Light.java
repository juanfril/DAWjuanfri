package automation.data;

public class Light extends AutomationElement implements Lockable{

    String name;
    boolean switchHow;

    public Light(String name) { this.name = name; }

    @Override
    public String getName() { return name; }

    @Override
    public void setName(String name) { this.name = name; }

    @Override
    public void on(){ switchHow = true; }

    @Override
    public void off(){ switchHow = false; }

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
