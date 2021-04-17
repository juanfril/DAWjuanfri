package educational.controller;

import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.stage.Stage;

import java.net.URL;
import java.util.ResourceBundle;

public class UnderController extends GeneralController {
    @FXML
    private Button btnCatchTheMouse;
    @FXML
    private Button btnHowMany;
    private Stage stage = new Stage();
    private Parent root;

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        btnCatchTheMouse.setOnAction(ActionEvent -> {
            try {
                root = FXMLLoader.load(getClass().getResource(
                        "/educational/scene/catchTheMouseScene.fxml"));
                stage.setTitle("Catch the mouse");
            } catch (Exception e) {
                dialog.setHeaderText("Information");
                dialog.setContentText(e.toString());
                dialog.showAndWait();
            }
            stage.setScene(new Scene(root, 600, 400));
            stage.show();
        });
        btnHowMany.setOnAction(actionEvent -> {
            try {
                root = FXMLLoader.load(getClass().getResource(
                        "/educational/scene/howManyAreThereScene.fxml"));
                stage.setTitle("How many are there scene");
            } catch (Exception e) {
                dialog.setHeaderText("Information");
                dialog.setContentText(e.toString());
                dialog.showAndWait();
            }
            stage.setScene(new Scene(root, 600, 400));
            stage.show();
        });
    }
}
