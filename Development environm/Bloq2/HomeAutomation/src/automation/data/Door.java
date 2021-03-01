package automation.data;

public class Door extends AutomationElement implements Lockable{

    protected String name;
    private boolean lock;

    public Door(String name) { this.name = name; }

    @Override
    public String getName() { return name; }

    @Override
    public void setName(String name) { this.name = name; }

    public void on(){ lock = true; }

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
        return "- " + name + ": " + getStatus();
    }
}
