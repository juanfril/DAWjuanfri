package automation.data;

public interface Percent {

    public void lower();

    public void lower(int down);

    public void raise();

    public void raise(int up);

    public int getPercent();

    public void setPercent(int number);
}
