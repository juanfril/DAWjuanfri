package automation.data;

public class Window extends AutomationLock {
    public Window(String name) {
        super(name);
    }

    @Override
    public String toString(){
        return super.toString() + " " + Blind.getPercent() + "%";
    }
}
