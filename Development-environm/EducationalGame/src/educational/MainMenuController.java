package educational;

import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;

import java.net.URL;
import java.util.ResourceBundle;

public class MainMenuController extends GeneralController {

    public Button btnGo;
    Alert dialog = new Alert(Alert.AlertType.INFORMATION);

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

    @Override
    public void clic(ActionEvent actionEvent) {
    }
}
