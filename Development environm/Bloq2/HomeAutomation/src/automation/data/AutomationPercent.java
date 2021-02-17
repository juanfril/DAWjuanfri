package automation.data;

public abstract class AutomationPercent {
    private static int percent;
    String name;

    public AutomationPercent(){
        percent = 0;
        name = "Standard";
    }
    public AutomationPercent(String name){
        this.name = name;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void raise(){
        percent = 100;
    }
    public void lower(){
        percent = 0;
    }
    public  void raise(int percent){
        if(AutomationPercent.percent + percent > 100)
            System.out.println("You can't open more than 100%");
        else
            AutomationPercent.percent += percent;
    }
    public void lower(int percent){
        if(AutomationPercent.percent - percent < 0)
            System.out.println("You can't close more than 0%");
        else
            AutomationPercent.percent -= percent;
    }
    public static int getPercent(){
        return percent;
    }
    @Override
    public String toString(){
        return " " + getPercent() + "%";
    }
}
