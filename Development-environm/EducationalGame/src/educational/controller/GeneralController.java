package educational.controller;

import educational.model.Record;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.stage.Stage;

import java.net.URL;
import java.util.ArrayList;
import java.util.Random;
import java.util.ResourceBundle;
/**
 * SuperClass for controller Scenes
 * Implement Initializable
 * @see Initializable
 */
public class GeneralController implements Initializable {

    protected Alert dialog = new Alert(Alert.AlertType.INFORMATION);

    public void setNumbers(){}

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {}

    public void clic(ActionEvent actionEvent) {}
}
