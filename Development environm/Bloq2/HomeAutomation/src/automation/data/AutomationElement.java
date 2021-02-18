package automation.data;

public interface AutomationElement {

    public String getName();
    public void setName(String a);
    public String getStatus();
    public void on();
    public void off();

    @Override
    public String toString();

}
