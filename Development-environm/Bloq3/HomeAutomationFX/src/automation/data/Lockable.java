package automation.data;

/**
 * Interface to define the behaviour of lockable elements, such as
 * doors and windows
 */
public interface Lockable
{
    public void lock();
    public void unlock();
    public boolean getStatus();
}
