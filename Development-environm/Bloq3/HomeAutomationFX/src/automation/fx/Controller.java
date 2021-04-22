package automation.fx;

import automation.data.*;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.*;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.net.URL;
import java.util.ArrayList;
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
    private ArrayList<AutomationElement> stats = new ArrayList<>();
    private String[] AUX = new String[2];
    private byte line = 0;
    private ObservableList<Integer> percent =
            FXCollections.observableArrayList(0, 25, 50, 75, 100);

    @Override
    public void initialize( URL url, ResourceBundle resourceBundle ) {
        elements = new AutomationElement[6];
        elements[0] = new GarageDoor("Garage door", true, 0);
        elements[1] = new Window("Living room window",
                new Blind("Living room window blind", 0));
        elements[2] = new Heating("Bathroom heating", 30);
        elements[3] = new Oven("Kitchen oven", 180);
        elements[4] = new Light("Bathroom Light", false);
        elements[5] = new Light("Living Room Light", false);
        cbPosition0.setItems(percent);
        cbPosition1.setItems(percent);

        loadStatus();

        if(elements[0] instanceof GarageDoor){
            lbPosition0.setText(elements[0].getName());
            changeButton(btnPosition0);
            //cbPosition0.((( GarageDoor ) elements[0]).getPercent());
            if((( GarageDoor ) elements[0]).getStatus()){
                btnPosition0.setText("ON");
                btnPosition0.setStyle("-fx-background-color: green");
            } else {
                btnPosition0.setText("OFF");
                btnPosition0.setStyle("-fx-background-color: red");
            }
            btnPosition0.setOnAction(clic -> {
                changeButton(btnPosition0);
            });
        }

        if(elements[1] instanceof Window){
            lbPosition1.setText(elements[1].getName());
            //cbPosition0.((( GarageDoor ) elements[0]).getPercent());
            if((( Window ) elements[1]).getStatus()){
                btnPosition1.setText("ON");
                btnPosition1.setStyle("-fx-background-color: green");
            } else {
                btnPosition1.setText("OFF");
                btnPosition1.setStyle("-fx-background-color: red");
            }
            btnPosition1.setOnAction(clic -> {
                changeButton(btnPosition1);
            });
        }
    }
    private void changeButton(Button button){
        if(button.getText().contains("ON")){
            button.setText("OFF");
            button.setStyle("-fx-background-color: red");
        } else {
            button.setText("ON");
            button.setStyle("-fx-background-color: green");
        }
    }

    private ArrayList loadStatus(){
        if (! (new File("status.dat")).exists() ) {
            System.out.println("File status.dat not found");
        }
        else {
            try {
                BufferedReader countFiles = new BufferedReader(
                        new FileReader("status.dat"));

                int numLines = ( int ) countFiles.lines().count();
                //System.out.println(numLines);
                countFiles.close();

                if (numLines != 0) {
                    //System.out.println("Hay líneas");
                    BufferedReader inputFile = new BufferedReader(
                            new FileReader("status.dat"));

                    for (int i = 0; i < line; i++) {
                        AUX = inputFile.readLine().split(";");

                        switch (i){
                            case 0:
                                if (elements[i] instanceof GarageDoor) {
                                    elements[0].setName(AUX[0]);
                                    if(AUX[1].contains("locked"))
                                        ((Lockable)elements[0]).lock();
                                    else
                                        ((Lockable)elements[0]).unlock();
                                    ((Blindable)elements[0]).lower(Integer.parseInt(AUX[2]));
                                }
                            break;

                            case 1:
                                if (elements[i] instanceof Window) {
                                    elements[1].setName(AUX[0]);
                                    if(AUX[1].contains("locked"))
                                        ((Lockable)elements[1]).lock();
                                    else
                                        ((Lockable)elements[1]).unlock();
                                    ((Blindable)elements[1]).lower(Integer.parseInt(AUX[2]));
                                }
                            break;

                            case 2:
                                if (elements[i] instanceof Heating) {
                                    elements[2].setName(AUX[0]);
                                    if(AUX[1].contains("on"))
                                        ((Switchable)elements[2]).switchOn();
                                    else
                                        ((Switchable)elements[2]).switchOff();
                                    ((Heating)elements[2]).setTemperature(Integer.parseInt(AUX[2]));
                                }
                            break;

                            case 3:
                                if (elements[i] instanceof Oven) {
                                    elements[3].setName(AUX[0]);
                                    if(AUX[1].contains("on"))
                                        ((Switchable)elements[3]).switchOn();
                                    else
                                        ((Switchable)elements[3]).switchOff();
                                    ((Heating)elements[3]).setTemperature(Integer.parseInt(AUX[2]));
                                }
                            break;

                            case 4:
                                if (elements[i] instanceof Light) {
                                    elements[4].setName(AUX[0]);
                                    if(AUX[1].contains("on"))
                                        ((Switchable)elements[4]).switchOn();
                                    else
                                        ((Switchable)elements[4]).switchOff();
                                }
                            break;

                            case 5:
                                if (elements[i] instanceof Light) {
                                    elements[5].setName(AUX[0]);
                                    if(AUX[1].contains("on"))
                                        ((Switchable)elements[5]).switchOn();
                                    else
                                        ((Switchable)elements[5]).switchOff();
                                }
                            break;

                        }
                    }
                    inputFile.close();
                }
            } catch (IOException fileError) {
                System.out.println(
                        "There has been some problems: " +
                                fileError.getMessage());
            }
        }
            return stats;
    }

    public void clic( ActionEvent actionEvent ) {
    }
}
