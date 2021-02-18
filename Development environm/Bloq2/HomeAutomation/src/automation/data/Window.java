package automation.data;

public class Window implements AutomationElement {
    String name;
    boolean lock;
    Blind blind = new Blind();

    public Window(String name, String nameBlind) {
        this.name = name;
        lock = false;
        Blind blind = new Blind(nameBlind);
    }

    @Override
    public String getName() { return name; }

    @Override
    public void setName(String name) { this.name = name; }

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
    public String toString(){
        return "- " + name + " " + getStatus() + ": " + blind;
    }
}
