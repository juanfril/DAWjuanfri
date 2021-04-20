package automation.data;

/**
 * Class to represent heating systems as automation elements
 */
public class Heating extends AutomationElement implements Switchable
{
    protected int temperature;
    protected boolean status;

    public Heating(String name, int temperature)
    {
        super(name);
        setTemperature(temperature);
        this.status = false;
    }

    public Heating(String name, int temperature, boolean status)
    {
        super(name);
        this.temperature = temperature;
        this.status = status;
    }

    public int getTemperature()
    {
        return temperature;
    }

    public void setTemperature(int temperature)
    {
        // We could limit the range of valid temperatures
        if (temperature >= 15 && temperature <= 40)
            this.temperature = temperature;
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
    public String toString() {
        return super.toString() + (status?"on":"off") + ";" + temperature;
    }
}
