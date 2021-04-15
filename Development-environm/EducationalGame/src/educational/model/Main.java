package educational.model;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Modality;
import javafx.stage.Stage;

public class Main extends Application {

    @Override
    public void start(Stage primaryStage) throws Exception{
        Parent root = FXMLLoader.load(getClass().getResource("/educational/scene/mainMenuScene.fxml"));
        primaryStage.setTitle("Educational game");
        primaryStage.setScene(new Scene(root, 600, 400));
        primaryStage.initModality(Modality.APPLICATION_MODAL);
        primaryStage.showAndWait();
    }

    public static void main(String[] args) {launch(args);}
}
