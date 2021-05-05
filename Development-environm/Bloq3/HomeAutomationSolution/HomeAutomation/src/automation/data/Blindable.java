package automation.data;

/**
 * Interface for those automation elements that act as blinds
 * and need to raise or lower
 */
public interface Blindable
{
    public void raise();
    public void raise(int percent);
    public void lower();
    public void lower(int percent);
    public int getPercent();
}
