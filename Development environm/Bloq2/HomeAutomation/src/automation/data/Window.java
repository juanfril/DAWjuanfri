package automation.data;

public class Window implements AutomationElement {
    String name;
    boolean lock;
    Blind blind;

    public Window(String name, String nameBlind) {
        this.name = name;
        lock = false;
        blind = new Blind();
        blind.setName(nameBlind);
    }

    @Override
    public String getName() { return name; }

    @Override
    public void setName(String name) { this.name = name; }

    @Override
    public int getNumber() {
        return blind.getNumber();
    }

    @Override
    public void setNumber(int number) {
        blind.setNumber(number);
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

    ;

    @Override
    public String toString(){
        return "- " + name + " " + getStatus() + ": " + blind;
    }
}
