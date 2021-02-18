package automation.data;

public class GarageDoor extends Door implements AutomationElement{
    int percent;

    public GarageDoor(String name) {
        super(name);
    }

    public void raise(){
        percent = 100;
    }

    public void lower(){
        percent = 0;
    }

    public  void raise(int percent){
        if(this.percent + percent > 100)
            System.out.println("You can't open more than 100%");
        else
            this.percent += percent;
    }
    public void lower(int percent){
        if(this.percent - percent < 0)
            System.out.println("You can't close more than 0%");
        else
            this.percent -= percent;
    }

    @Override
    public String toString(){
        return name + ": " + getStatus() + ", " + percent + "%";
    }
}
