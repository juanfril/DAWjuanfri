package automation.data;

public interface AutomationElement {

    public String getName();
    public void setName(String name);
    public int getNumber();
    public void setNumber(int number);
    public String getStatus();
    public void on();
    public void off();
    public void lower();
    public void lower(int down);
    public void raise();
    public void raise(int up);

    @Override
    public String toString();

}
