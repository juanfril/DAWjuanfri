package automation.data;

public class Door implements AutomationElement{

    String name;
    boolean lock;

    public Door(String name) { this.name = name; }

    @Override
    public String getName() { return name; }

    @Override
    public void setName(String name) { this.name = name; }

    public void lock(){ lock = true; }

    public void unlock(){ lock = false; }

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
