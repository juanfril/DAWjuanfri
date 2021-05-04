package automation.data;

/**
 * Subtype of door for garages. It can act as a blind,
 * so it must implement the corresponding interface
 */
public class GarageDoor extends Door implements Blindable
{
    private int percent;

    public GarageDoor(String name, boolean locked, int percent)
    {
        super(name, locked);
        this.percent = percent;
    }

    @Override
    public void raise()
    {
        this.percent = 100;
    }

    @Override
    public void raise(int percent)
    {
        this.percent = Math.min(100, this.percent + percent);
    }

    @Override
    public void lower()
    {
        this.percent = 0;
    }

    @Override
    public void lower(int percent)
    {
        this.percent = Math.max(0, this.percent - percent);
    }

    @Override
    public int getPercent()
    {
        return percent;
    }

    @Override
    public String toString() {
        return super.toString() + ", " + percent + "%";
    }
}
