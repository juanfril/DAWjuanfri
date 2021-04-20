package automation.data;

/**
 * Class to represent lightning systems
 */
public class Light extends AutomationElement implements Switchable
{
    private boolean status;

    public Light(String name, boolean status)
    {
        super(name);
        this.status = status;
    }

    @Override
    public void switchOn()
    {
        this.status = true;
    }

    @Override
    public void switchOff()
    {
        this.status = false;
    }

    @Override
    public boolean getStatus()
    {
        return this.status;
    }

    @Override
    public String toString()
    {
        return super.toString() + (status?"on":"off");
    }

}
