package automation.main;
import automation.data.*;

public class Management{
    private static AutomationElement[] home = new AutomationElement[9];

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
    public static void winter(){
        for (int i = 0; i < 4; i++) {
            home[i].on();
        }
        home[3].lower();
        home[0].setNumber(80);
        home[1].setNumber(80);
        home[4].raise();
        home[5].setNumber(25);
        home[7].off();
        home[6].setNumber(25);
        home[8].on();
        home[9].on();
    }
    public static void summer(){
        for (int i = 0; i < 4; i++) {
            home[i].off();
        }
        home[3].raise();
        home[0].setNumber(50);
        home[1].setNumber(50);
        home[4].setNumber(50);
        home[5].off();
        home[6].off();
        home[7].off();
        home[8].off();
        home[9].off();
    }
    public static void cooking(){
        home[8].on();
        home[7].on();
        home[7].setNumber(200);
        home[9].off();
    }
    public static void closeEverything(){
        for(var value : home){
            value.off();
            value.lower();
        }
    }
    public static void showStatus(){
        for(var value : home){
            System.out.println(value);
        }
    }
}
