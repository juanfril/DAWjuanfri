package automation.fx;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Alert;
import javafx.stage.Stage;

public class Main extends Application {

    @Override
    public void start(Stage primaryStage) {
        try{
            Parent root = FXMLLoader.load(getClass().getResource("/automation/fx/sample.fxml"));
            primaryStage.setTitle("Automation Home");
            primaryStage.setScene(new Scene(root, 600, 400));
            primaryStage.show();
        }catch (Exception exception) {
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setContentText(String.valueOf(exception));
            alert.showAndWait();
        }
    }

    public static void main(String[] args) {
        launch(args);
    }
}
