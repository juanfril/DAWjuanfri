package videogame;

import javafx.application.Application;
import javafx.stage.Stage;
import videogame.scenes.*;

public class EducationalGame extends Application {
    public static final int MAX_SCENES = 4;
    public static final int WELCOME_SCENE = 0;
    public static final int LESS_THAN_GAME_SCENE = 1;
    public static final int MORE_THAN_GAME_SCENE = 2;
    public static final int CREDITS_SCENE = 3;

    public static final GeneralScene[] scenes =
            new GeneralScene[MAX_SCENES];

    private static Stage stage;

    @Override
    public void start(Stage stage) throws Exception {

        this.stage = stage;

        scenes[0] = new WelcomeScene();
        scenes[1] = new LessThan3YearsGameScene();
        scenes[2] = new MoreThan3YearsGameScene();
        scenes[3] = new CreditsScene();

        stage.setTitle("Educational Game");
        setScene(WELCOME_SCENE);
        stage.show();
    }

    public static void setScene(int numScene){
        stage.setScene(scenes[numScene]);
        scenes[numScene].draw();
    }

    public static void exit(){
        stage.hide();
    }

    public static void main(String[] args) {
        launch(args);
    }
}
