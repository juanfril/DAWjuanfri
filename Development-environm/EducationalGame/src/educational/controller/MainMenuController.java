package educational.controller;

import educational.model.Player;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.control.TextField;

import java.net.URL;
import java.util.ResourceBundle;

public class MainMenuController extends GeneralController {

    public TextField txtAge;
    @FXML
    private TextField txtName;
    @FXML
    private Button btnGo;
    Player player;

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        btnGo.setOnAction(new EventHandler<ActionEvent>() {
            @Override
            public void handle(ActionEvent actionEvent) {
                dialog.setHeaderText("Informacion");
                dialog.setContentText("Hello world");
                dialog.showAndWait();
            }
        });
    }

    @FXML @Override
    public void clic(ActionEvent actionEvent) {}

    @FXML
    private void saveName(ActionEvent event){
        player = new Player(this.txtName.getText(), Byte.parseByte(this.txtAge.getText()));
    }
}
