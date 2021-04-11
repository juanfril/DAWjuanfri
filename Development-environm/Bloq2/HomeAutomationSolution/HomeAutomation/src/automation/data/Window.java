package automation.data;

/**
 * Another automation element that represents a window
 */
public class Window extends AutomationElement implements Lockable
{
    private Blind blind;
    private boolean locked;

    public Window(String name, Blind blind)
    {
        super(name);
        this.blind = blind;
        this.locked = true;
    }

    public Window(String name, Blind blind, boolean locked)
    {
        super(name);
        this.blind = blind;
        this.locked = locked;
    }

    public Blind getBlind()
    {
        return blind;
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
        return super.toString() + ": " + (locked? "locked":"unlocked") + ", " + blind.getPercent() + "%";
    }
}
