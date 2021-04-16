package educational.controller;

import educational.model.Player;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;

import java.net.URL;
import java.util.ResourceBundle;

public class OlderController extends GeneralController {

    @FXML
    private Button btnSums;
    @FXML
    private Button btnSubtract;
    @FXML
    private Button btnSubtractWithCarriedController;

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        btnSums.setOnAction(ActionEvent -> {

                dialog.setHeaderText("Information");
                dialog.setContentText("To sums window");
                dialog.showAndWait();
        });
        btnSubtract.setOnAction(actionEvent -> {

            dialog.setHeaderText("Information");
            dialog.setContentText("To subtract window");
            dialog.showAndWait();
        });
        btnSubtractWithCarriedController.setOnAction(actionEvent -> {

            dialog.setHeaderText("Information");
            dialog.setContentText("To SWC window");
            dialog.showAndWait();
        });
    }
}
