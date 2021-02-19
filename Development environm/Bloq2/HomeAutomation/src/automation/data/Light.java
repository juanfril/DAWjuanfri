package automation.data;

public class Light implements AutomationElement{

    String name;
    boolean switchHow;

    public Light(String name) { this.name = name; }

    @Override
    public String getName() { return name; }

    @Override
    public void setName(String a) { this.name = name; }

    @Override
    public int getNumber() {
        return 0;
    }

    @Override
    public void setNumber(int number) {

    }

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
        return "- " + name + ": " + getStatus();
    }
}
