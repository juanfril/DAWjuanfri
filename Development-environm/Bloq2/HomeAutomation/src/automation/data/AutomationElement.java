package automation.data;

public abstract class AutomationElement {

    private String name;

    public String getName() { return name; }

    public void setName(String name) { this.name = name; }

    /*public int getPercent() { return -1; } todo esto no hacía falta

    public void setPercent(int number) {}

    public int getTemperature() { return -1; }

    public void setTemperature(int number) {}

    public String getStatus() { return null; }

    public void on() {}

    public void off() {}

    public void lower() {}

    public void lower(int down) {}

    public void raise() {}

    public void raise(int up) {}*/

    @Override
    public String toString(){
        return "- " + name;
    }

}
