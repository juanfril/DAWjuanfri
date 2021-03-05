package automation.data;

public class Awning extends Blind implements Percent{

    public Awning(String name) {
        super(name);
    }

    @Override
    public String toString(){
        return "- " + super.toString();
    }
}
