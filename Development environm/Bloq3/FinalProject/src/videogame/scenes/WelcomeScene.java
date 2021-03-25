package videogame.scenes;

import javafx.animation.AnimationTimer;
import javafx.scene.image.Image;
import javafx.scene.input.KeyCode;
import javafx.scene.paint.Color;
import javafx.scene.text.Font;
import javafx.scene.text.FontWeight;
import videogame.EducationalGame;

import java.nio.file.Files;
import java.nio.file.Paths;

public class WelcomeScene extends GeneralScene {

    private static final String BACKGROUND_IMAGE = "assets/background.jpg";

    private Image background;

    public WelcomeScene() {
        super();
        try {
            background = new Image(Files.newInputStream(Paths.get(BACKGROUND_IMAGE)));
        } catch (Exception e) {
            e.printStackTrace();
        }
        showWelcomeMessage();
    }

    private void showWelcomeMessage() {
        Font myFont = Font.font("Lucida Handwriting", FontWeight.NORMAL, 80);
        gc.setFont(myFont);
        gc.setFill(Color.RED);
        gc.fillText("Educational Game", 200, 200);

        myFont = Font.font("Lucida Handwriting", FontWeight.NORMAL, 40);
        gc.setFont(myFont);
        gc.setFill(Color.BLUE);
        gc.fillText("Press 1 for play to 3 years", 275, 300);
        gc.fillText("Press 2 for play 3 years or more", 275, 350);
    }

    @Override
    public void draw() {
        activeKeys.clear();
        new AnimationTimer() {
            public void handle(long currentNanoTime) {
                gc.setFill(Color.BLACK);
                gc.fillRect(0, 0, GAME_WIDTH, GAME_HEIGHT);

                gc.drawImage(background, 0, 0);
                showWelcomeMessage();

                if (activeKeys.contains(KeyCode.DIGIT1)) {
                    this.stop();
                    EducationalGame.setScene(EducationalGame.LESS_THAN_GAME_SCENE);
                } else if(activeKeys.contains(KeyCode.DIGIT2)){
                    this.stop();
                    EducationalGame.setScene(EducationalGame.MORE_THAN_GAME_SCENE);
                } else if (activeKeys.contains(KeyCode.ESCAPE)) {
                    this.stop();
                    EducationalGame.exit();
                }
            }
        }.start();
    }
}
