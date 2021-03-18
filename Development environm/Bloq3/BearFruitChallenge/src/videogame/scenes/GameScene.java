package videogame.scenes;

import javafx.animation.AnimationTimer;
import javafx.scene.image.Image;
import javafx.scene.input.KeyCode;
import javafx.scene.paint.Color;
import javafx.scene.text.Font;
import javafx.scene.text.FontWeight;
import videogame.BearFruitChallenge;

import java.nio.file.Files;
import java.nio.file.Paths;


public class GameScene extends GeneralScene{

    private static final String BACKGROUND_IMAGE = "assets/background.png";
    private static final String BEAR_IMAGE = "assets/bear.png";

    private Image background;
    private Image bear;

    public GameScene(){
        super();
        try {
            background = new Image(Files.newInputStream(Paths.get(BACKGROUND_IMAGE)));
            bear = new Image(Files.newInputStream(Paths.get(BEAR_IMAGE)));
        } catch (Exception e){
            e.printStackTrace();
        }
    }

    @Override
    public void draw() {
        activeKeys.clear();
        ( AnimationTimer ) ( currentNanoTime ) -> {
            gc.setFill(Color.BLACK);
            gc.fillRect(0, 0, GAME_WIDTH, GAME_HEIGHT);

            gc.drawImage(background, 0, 0);
            gc.drawImage(bear, 0, 0, 96, 96,  380, 375, 96, 96);

            if(activeKeys.contains(KeyCode.ESCAPE)){
                this.stop();
                BearFruitChallenge.setScene(BearFruitChallenge.WELCOME_SCENE);
            } else if(activeKeys.contains(KeyCode.ENTER)){
                this.stop();
                BearFruitChallenge.setScene(BearFruitChallenge.CREDITS_SCENE);
            }
        }.start();
    }
}
