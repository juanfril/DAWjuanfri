package videogame.scenes;

import javafx.animation.AnimationTimer;
import javafx.scene.input.KeyCode;
import javafx.scene.paint.Color;
import javafx.scene.text.Font;
import javafx.scene.text.FontWeight;
import videogame.BearFruitChallenge;

public class GameScene extends GeneralScene{

    public GameScene(){
        super();
    }

    private void showGameMessage(){
        Font myFont = Font.font("Arial", FontWeight.NORMAL, 24);
        gc.setFont(myFont);
        gc.setFill(Color.YELLOW);
        gc.fillText("Game start", 325, 200);
    }

    @Override
    public void draw() {
        activeKeys.clear();
        (AnimationTimer) (currentNanoTime) -> {
            gc.setFill(Color.BLACK);
            gc.fillRect(0, 0, GAME_WIDTH, GAME_HEIGHT);

            showGameMessage();

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
