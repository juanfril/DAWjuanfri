package automation.data;

/**
 * Class to represent automation elements of type door
 */
public class Door extends AutomationElement implements Lockable
{
    protected boolean locked;

    public Door(String name, boolean locked)
    {
        super(name);
        this.locked = locked;
    }

    @Override
    public void lock()
    {
        this.locked = true;
    }

    @Override
    public void unlock()
    {
        this.locked = false;
    }

    @Override
    public boolean getStatus()
    {
        return locked;
    }

    @Override
    public String toString()
    {
        return super.toString() + (locked? "locked":"unlocked");
    }
}
