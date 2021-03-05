package automation.data;

public class Window extends AutomationElement
    implements Lockable{

    private String name;
    protected boolean lock;
    Blind blind = new Blind(); //I'm sorry but if I don't do that, don't work...

    public Window(String name, String nameBlind) {
        this.name = name;
        lock = false;
        blind.setName(nameBlind);
    }

    @Override
    public String getName() { return name; }

    @Override
    public void setName(String name) { this.name = name; }

    @Override
    public int getPercent() {
        return blind.getPercent();
    }

    @Override
    public void setPercent(int number) {
        blind.setPercent(number);
    }

    @Override
    public void on(){ lock = true; }

    @Override
    public void off(){ lock = false; }

    @Override
    public String getStatus() {
        if(lock)
            return "Lock";
        else
            return "Unlock";
    }

    @Override
    public void lower(){ blind.lower(); }

    @Override
    public void lower(int down) { blind.lower(down); }

    @Override
    public void raise() { blind.raise(); }

    @Override
    public void raise(int up) { blind.raise(up); }

    @Override
    public String toString(){
        return "- " + name + " " + getStatus() + ": " + blind;
    }
}
