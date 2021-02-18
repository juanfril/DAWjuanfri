package automation.main;
import automation.data.*;

public class Management{
    AutomationElement[] home = new AutomationElement[9];

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
    public void lock(){

    }
}
