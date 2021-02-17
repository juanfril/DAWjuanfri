package automation.data;

public abstract class AutomationLock {
    boolean lock;
    String nameLock;

    public String getNameLock() { return nameLock; }

    public void setNameLock(String name) { this.nameLock = name; }

    public AutomationLock(String name){
        this.nameLock = name;
    }

    public void lock(){
        lock = true;
    }
    public void unlock(){
        lock = false;
    }
    public String getStatus(){
        if(lock)
            return "Locked";
        else
            return "Unlocked";
    }

    public AutomationLock(){
        lock = false;
    }
    @Override
    public String toString(){
        return "- " + nameLock + ": " + getStatus();
    }
}
