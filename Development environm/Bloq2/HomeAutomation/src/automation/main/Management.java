package automation.main;
import automation.data.*;

public class Management{
    private AutomationElement[] home = new AutomationElement[10];

    public Management(){
        home[0] = new Window("Room window", "Room blind");
        home[1] = new Window("Living room window", "Living room blind");
        home[2] = new Door("Main door");
        home[3] = new GarageDoor("Garage door");
        home[4] = new Awning("Terrace awning");
        home[5] = new Heating("Room heating");
        home[6] = new Heating("Bathroom heating");
        home[7] = new Oven("Kitchen oven");
        home[8] = new Light("Kitchen light");
        home[9] = new Light("Room light");
    }
    public void winter(){
        for (int i = 0; i < home.length; i++) {
            if (home[i] instanceof Window){
                home[i].on();
                home[i].setPercent(80);
            }
            if(home[i] instanceof Door){
                home[i].on();
            }
            if(home[i] instanceof GarageDoor) {
                home[i].on();
                home[i].lower();
            }
            if(home[i] instanceof Awning) {
                home[i].raise();
            }
            if(home[i] instanceof Heating){
                home[i].on();
                home[i].setTemperature(25);
            }
            if(home[i] instanceof Oven){
                home[i].off();
            }
            if(home[i] instanceof Light){
                home[i].on();
            }
        }
    }
    public void summer(){
        for (int i = 0; i < home.length; i++) {
            if (home[i] instanceof Window) {
                home[i].off();
                home[i].setPercent(50);
            }
            if (home[i] instanceof Door) {
                home[i].off();
            }
            if (home[i] instanceof GarageDoor) {
                home[i].off();
                home[i].raise();
            }
            if (home[i] instanceof Awning) {
                home[i].setPercent(50);
            }
            if (home[i] instanceof Heating) {
                home[i].off();
                home[i].setTemperature(25);
            }
            if (home[i] instanceof Oven) {
                home[i].off();
            }
            if (home[i] instanceof Light) {
                home[i].off();
            }
        }
    }
    public void cooking(){
            for (int i = 0; i < home.length; i++) {
                if (home[i] instanceof Window) {
                    home[i].off();
                    home[i].setPercent(50);
                }
                if (home[i] instanceof Door) {
                    home[i].off();
                }
                if (home[i] instanceof GarageDoor) {
                    home[i].off();
                    home[i].raise();
                }
                if (home[i] instanceof Awning) {
                    home[i].setPercent(50);
                }
                if (home[i] instanceof Heating) {
                    home[i].off();
                    home[i].setTemperature(25);
                }
                if (home[i] instanceof Oven) {
                    home[i].on();
                    home[i].setTemperature(200);
                }
                if (home[i] instanceof Light) {
                    if (i == 8)
                        home[8].on();
                    else
                        home[i].off();
                }
            }
    }
    public void closeEverything(){
        for(var value : home){
            if(value instanceof Window || value instanceof Door ||
                value instanceof GarageDoor){

                value.on();
                value.lower();
            }
            else
                value.off();
        }
    }
    public void showStatus(){
        for(var value : home){
            System.out.println(value);
        }
    }
}
