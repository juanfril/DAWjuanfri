package automation.data;

interface AutomationElement {

    public String getName();
    public void setName(String a);
    public String getStatus();

    @Override
    public String toString();

}
