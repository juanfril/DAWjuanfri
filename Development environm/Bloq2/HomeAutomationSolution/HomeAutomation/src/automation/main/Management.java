package automation.main;

import automation.data.*;

import java.util.Scanner;

/**
 * This class manages every automation element of a house
 * We initialize it with a predefined set of elements
 * and add methods to manage every aspect of the house
 */
public class Management
{
    private static final int MAX_ELEMENTS = 10;
    private AutomationElement[] elements;

    public Management()
    {
        elements = new AutomationElement[MAX_ELEMENTS];
        elements[0] = new Window("Room window",
            new Blind("Room window blind", 0));
        elements[1] = new Window("Living room window",
            new Blind("Living room window blind", 0));
        elements[2] = new Awning("Terrace awning", 100);
        elements[3] = new Door("Main door", true);
        elements[4] = new GarageDoor("Garage door", true, 0);
        elements[5] = new Light("Kitchen light", false);
        elements[6] = new Light("Room light", false);
        elements[7] = new Heating("Room heating", 23);
        elements[8] = new Heating("Bathroom heating", 30);
        elements[9] = new Oven("Kitchen oven", 180);
    }

    public void winterMode()
    {
        for(AutomationElement element: elements)
        {
            if (element instanceof Lockable)
            {
                ((Lockable) element).lock();
            }
            if (element instanceof GarageDoor)
            {
                ((GarageDoor) element).lower();
            }
            if (element instanceof Awning)
            {
                ((Awning) element).raise();
            }
            if (element instanceof Window)
            {
                ((Window) element).getBlind().lower();
                ((Window) element).getBlind().raise(80);
            }
            if (element instanceof Heating && !(element instanceof Oven))
            {
                ((Heating) element).switchOn();
                ((Heating) element).setTemperature(25);
            }
            if (element instanceof Light)
            {
                ((Light) element).switchOn();
            }
        }
    }

    public void summerMode()
    {
        for(AutomationElement element: elements)
        {
            if (element instanceof Lockable)
            {
                ((Lockable) element).unlock();
            }
            if (element instanceof GarageDoor)
            {
                ((GarageDoor) element).raise();
            }
            if (element instanceof Awning)
            {
                ((Awning) element).lower();
                ((Awning) element).raise(50);
            }
            if (element instanceof Window)
            {
                ((Window) element).getBlind().lower();
                ((Window) element).getBlind().raise(50);
            }
            if (element instanceof Switchable)
            {
                ((Switchable) element).switchOff();
            }
        }
    }

    public void cookingMode()
    {
        ((Light) elements[5]).switchOn();
        ((Light) elements[6]).switchOff();
        ((Oven) elements[9]).switchOn();
        ((Oven) elements[9]).setTemperature(200);
    }

    public void closeEverything()
    {
        for (AutomationElement element: elements)
        {
            if (element instanceof Blindable)
            {
                ((Blindable) element).lower();
            }
            if (element instanceof Window)
            {
                ((Window) element).getBlind().lower();
            }
            if (element instanceof Switchable)
            {
                ((Switchable) element).switchOff();
            }
            if (element instanceof Lockable)
            {
                ((Lockable) element).lock();
            }
        }
    }

    public void showStatus()
    {
        System.out.println("Overall status of the house:");
        for (AutomationElement element : elements)
            System.out.println(element);
    }
}
