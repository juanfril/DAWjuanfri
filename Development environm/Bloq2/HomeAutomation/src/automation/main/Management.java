package automation.main;
import automation.data.*;

public class Management {
    AutomationPercent[] percents = new AutomationPercent[3];
    AutomationLock[] locks = new AutomationLock[4];
    AutomationSwitch[] switches = new AutomationSwitch[5];

    public Management(){
        percents[0] = new Blind("Room blind");
        percents[1] = new Blind("Living room blind");
        percents[3] = new Awning("Terrace awning");
        locks[0] = new Window("Room window");
        locks[1] = new Window("Living room window");
        locks[2] = new Door("Main door");
        locks[3] = new GarageDoor("Garage door");
        switches[0] = new Heating("Room heating");
        switches[1] =  new Heating("Bathroom heating");
        switches[2] = new Light("Kitchen light");
        switches[3] = new Light("Room light");
        switches[4] = new Oven("Room light");
    }
}
