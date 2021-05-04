package automation.data;

/**
 * Blinds are an AutomationElement subtype which can act as blinds
 * and then raise or lower.
 */
public class Blind extends AutomationElement implements Blindable
{
    protected int percent;

    public Blind(String name, int percent)
    {
        super(name);
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
        if(percent < 0)
            percent = 0;
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
        if(percent < 0)
            percent = 0;
        this.percent = Math.max(0, this.percent - percent);
    }

    @Override
    public int getPercent()
    {
        return percent;
    }

    @Override
    public String toString()
    {
        return super.toString() + ": " + percent + "%";
    }
}
