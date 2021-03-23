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

public class LessThan3YearsGameScene extends GeneralScene{

    private static final String BACKGROUND_IMAGE = "assets/moreThan3YearsGame.jpg";

    private Image background;

    public LessThan3YearsGameScene() {
        super();
        try {
            background = new Image(Files.newInputStream(Paths.get(BACKGROUND_IMAGE)));
        } catch (Exception e) {
            e.printStackTrace();
        }
    }


    @Override
    public void draw() {
        activeKeys.clear();
        new AnimationTimer() {
            public void handle(long currentNanoTime) {
                gc.setFill(Color.BLACK);
                gc.fillRect(0, 0, GAME_WIDTH, GAME_HEIGHT);

                gc.drawImage(background, 0, 0);


                if (activeKeys.contains(KeyCode.ENTER)) {
                    this.stop();
                    EducationalGame.setScene(EducationalGame.WELCOME_SCENE);
                } else if (activeKeys.contains(KeyCode.ESCAPE)) {
                    this.stop();
                    EducationalGame.setScene(EducationalGame.CREDITS_SCENE);
                }

            }
        }.start();
    }
}
