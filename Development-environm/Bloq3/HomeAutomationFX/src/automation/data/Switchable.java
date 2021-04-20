package automation.data;

/**
 * Interface for elements that can be switched on/off
 */
public interface Switchable
{
    public void switchOn();
    public void switchOff();
    public boolean getStatus();
}
