package automation.data;

/**
 * Generic, abstract class for every automation element (blinds, doors and so on...)
 */
public abstract class AutomationElement
{
    protected String name;

    public AutomationElement(String name)
    {
        this.name = name;
    }

    public String getName()
    {
        return name;
    }

    public void setName(String name)
    {
        this.name = name;
    }

    @Override
    public String toString()
    {
        return name + ";";
    }
}
