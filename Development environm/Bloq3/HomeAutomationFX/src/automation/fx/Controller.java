package automation.fx;

import automation.data.*;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.*;

import java.net.URL;
import java.util.ResourceBundle;

public class Controller implements Initializable{
    @FXML
    private ComboBox cbPosition0, cbPosition1;
    @FXML
    private TextField txtTemperatureHeating, txtTemperatureOven;
    @FXML
    private Label lbPosition0, lbPosition1, lbPosition2, lbPosition3,
        lbPosition4, lbPosition5;
    @FXML
    private Button btnPosition0, btnPosition1, btnPosition2, btnPosition3,
        btnPosition4, btnPosition5, btnApply;

    private AutomationElement[] elements;

    @Override
    public void initialize( URL url, ResourceBundle resourceBundle ) {
        elements = new AutomationElement[5];
        elements[2] = new Window("Room window",
                new Blind("Room window blind", 0));
        elements[1] = new Window("Living room window",
                new Blind("Living room window blind", 0));
        elements[8] = new Heating("Bathroom heating", 30);
        elements[9] = new Oven("Kitchen oven", 180);
        elements[0] = new GarageDoor("Garage door", true, 0);
    }
}
