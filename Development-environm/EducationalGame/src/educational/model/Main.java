package educational.model;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Alert;
import javafx.stage.Modality;
import javafx.stage.Stage;

public class Main extends Application {

    @Override
    public void start(Stage primaryStage) {

        try{
            Parent root = FXMLLoader.load(getClass().getResource("/educational/scene/mainMenuScene.fxml"));
            primaryStage.setTitle("Educational game");
            primaryStage.setScene(new Scene(root, 600, 400));
            primaryStage.show();

        } catch (Exception exception){
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setContentText(String.valueOf(exception));
            alert.showAndWait();
        }
    }

    public static void main(String[] args) {launch(args);}
}
