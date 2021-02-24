package automation.data;

public class Blind extends AutomationElement implements Percent{
    String name;
    int percent;

    public Blind(){
        name = "Generic";
    }

    public Blind(String name) {
        this.name = name;
        percent = 0;
    }

    @Override
    public String getName() { return name; }

    @Override
    public void setName(String name) { this.name = name; }

    @Override
    public int getPercent() { return percent; }

    @Override
    public void setPercent(int number){ percent = number; }

    @Override
    public void raise(){
        percent = 100;
    }

    @Override
    public void lower(){
        percent = 0;
    }

    @Override
    public  void raise(int percent){
        if(this.percent + percent > 100)
            System.out.println("You can't open more than 100%");
        else
            this.percent += percent;
    }

    @Override
    public void lower(int percent){
        if(this.percent - percent < 0)
            System.out.println("You can't close more than 0%");
        else
            this.percent -= percent;
    }

    @Override
    public String getStatus() {
        return percent + "%";
    }

    @Override
    public String toString(){
        return name + ": " + percent + "%";
    }

}
