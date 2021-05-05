package automation.data;

/**
 * An awning is a subtype of blind, so it inherits
 * the same methods from parent class to raise, lower
 * and so on
 */
public class Awning extends Blind
{
    public Awning(String name, int percent)
    {
        super(name, percent);
    }
}
