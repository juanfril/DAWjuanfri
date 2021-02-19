package automation.data;

public class Door implements AutomationElement{

    String name;
    boolean lock;

    public Door(String name) { this.name = name; }

    @Override
    public String getName() { return name; }

    @Override
    public void setName(String name) { this.name = name; }

    @Override
    public int getNumber() { return 0; }

    @Override
    public void setNumber(int number){}

    public void on(){ lock = true; }

    public void off(){ lock = false; }

    @Override
    public void lower(){}

    @Override
    public void lower(int down){}

    @Override
    public void raise(int up) {}

    @Override
    public void raise(){}

    @Override
    public String getStatus() {
        if(lock)
            return "Lock";
        else
            return "Unlock";
    }

    @Override
    public String toString(){
        return "- " + name + ": " + getStatus();
    }
}
