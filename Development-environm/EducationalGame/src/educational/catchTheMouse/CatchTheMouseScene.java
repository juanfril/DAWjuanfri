package educational.catchTheMouse;

import educational.controller.GeneralController;
import javafx.animation.AnimationTimer;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.scene.Scene;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.input.KeyCode;
import javafx.scene.layout.StackPane;
import javafx.scene.media.Media;
import javafx.scene.media.MediaPlayer;
import javafx.scene.paint.Color;

import java.net.URL;
import java.util.HashSet;
import java.util.ResourceBundle;
import java.util.Set;

/**
 * Class for controller catchTheMouseScene
 * Inheritance GeneralController
 * @see Scene
 */
public class CatchTheMouseScene extends Scene {
    public static final int GAME_WIDTH = 816;
    public static final int GAME_HEIGHT = 480;

    private StackPane root = new StackPane();
    protected GraphicsContext gc;
    protected MediaPlayer mediaPlayer;
    private Mouse mouse;

    public CatchTheMouseScene() {
        //Call to Scene constructor to initialize it
        super(new StackPane(), GAME_WIDTH, GAME_HEIGHT);

        //Change scene's root to our own stack pane
        root = new StackPane();
        this.setRoot(root);

        //Initialize canvas and graphics context
        Canvas canvas = new Canvas(GAME_WIDTH, GAME_HEIGHT);
        root.getChildren().add(canvas);
        gc = canvas.getGraphicsContext2D();
        mouse = new Mouse();
    }
    public void draw(){
        mouse.moveTo(380, 375);
        new AnimationTimer() {
            public void handle(long currentNanoTime) {
                gc.setFill(Color.BLACK);
                gc.fillRect(0, 0, GAME_WIDTH, GAME_HEIGHT);

                mouse.draw(gc);
            }
        }.start();
    }
}
