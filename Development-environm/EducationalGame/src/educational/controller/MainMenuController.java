package educational.controller;

import educational.model.Player;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.control.TextField;

//import java.awt.*;
import java.net.URL;
import java.util.ResourceBundle;

public class MainMenuController extends GeneralController {

    @FXML
    public TextField txtAge;
    @FXML
    private TextField txtName;
    @FXML
    private Button btnGo;
    Player player;

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        btnGo.setOnAction(actionEvent -> {
            player = new Player(txtName.getText(), Byte.parseByte(txtAge.getText()));

            dialog.setHeaderText("Information");
            dialog.setContentText(player.toString());
            dialog.showAndWait();
        });
    }

    /*@FXML @Override
    public void clic(ActionEvent actionEvent) {}*/

}
