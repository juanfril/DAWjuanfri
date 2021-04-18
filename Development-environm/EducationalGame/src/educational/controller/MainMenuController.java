package educational.controller;

import educational.model.Player;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.TextField;
import javafx.stage.Stage;

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
    private byte age;

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        btnGo.setOnAction(actionEvent -> {
            try{
                age = Byte.parseByte(txtAge.getText());
                player = new Player(txtName.getText(), age);
                Parent root;
                Stage stage = new Stage();

                if(age > 3){
                    root = FXMLLoader.load(getClass().getResource(
                            "/educational/scene/olderScene.fxml"));
                    stage.setTitle("Older than 3 menu");
                } else {
                    root = FXMLLoader.load(getClass().getResource(
                            "/educational/scene/underScene.fxml"));
                    stage.setTitle("Under than 3 menu");
                }
                stage.setScene(new Scene(root, 600, 400));
                stage.show();
            }catch (Exception exception){
                dialog.setHeaderText("Information");
                dialog.setContentText("Age must be a number (0-10)");
                dialog.showAndWait();
            }
        });
    }
}