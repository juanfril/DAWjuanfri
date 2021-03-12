package automation.data;

/**
 * This is a subtype of heating system
 */
public class Oven extends Heating
{
    public Oven(String name, int temperature)
    {
        super(name, temperature);
    }

    public Oven(String name, int temperature, boolean status)
    {
        super(name, temperature, status);
    }

    // We redefine temperature setter to adjust temperatures
    public void setTemperature(int temperature)
    {
        // We could limit the range of valid temperatures
        if (temperature >= 0 && temperature <= 300)
            this.temperature = temperature;
    }
}
