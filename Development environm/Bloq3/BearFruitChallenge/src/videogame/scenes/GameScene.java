package videogame.scenes;

import javafx.animation.AnimationTimer;
import javafx.scene.image.Image;
import javafx.scene.input.KeyCode;
import javafx.scene.media.Media;
import javafx.scene.media.MediaPlayer;
import javafx.scene.paint.Color;
import videogame.BearFruitChallenge;
import videogame.sprites.Fruit;
import videogame.sprites.MainCharacter;

import java.io.File;
import java.nio.file.Files;
import java.nio.file.Paths;


public class GameScene extends GeneralScene {

    private static final String BACKGROUND_IMAGE = "assets/background.png";
    public static final String BACKGROUND_SOUND = "assets/autumn-leaves.wav";
    public static final String SOUND_EFFECT = "assets/quick-jump.wav";

    private Image background;
    private MainCharacter bear;
    private Fruit fruit = null;
    private MediaPlayer mediaPlayerEffects;
    private Media effect;

    public GameScene() {
        super();
        try {
            background = new Image(Files.newInputStream(Paths.get(BACKGROUND_IMAGE)));
            bear = new MainCharacter();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    @Override
    public void draw() {

        sound = new Media(new File(BACKGROUND_SOUND).toURI().toString());
        mediaPlayer = new MediaPlayer(sound);
        mediaPlayer.setCycleCount(MediaPlayer.INDEFINITE);
        mediaPlayer.play();

        activeKeys.clear();
        bear.moveTo(380, 375);
        new AnimationTimer() {
            public void handle(long currentNanoTime) {
                gc.setFill(Color.BLACK);
                gc.fillRect(0, 0, GAME_WIDTH, GAME_HEIGHT);

                gc.drawImage(background, 0, 0);
                bear.draw(gc);
                if(fruit != null)
                    fruit.draw(gc);

                if (activeKeys.contains(KeyCode.ESCAPE)) {
                    this.stop();
                    BearFruitChallenge.setScene(BearFruitChallenge.WELCOME_SCENE);
                    mediaPlayer.stop();
                } else if (activeKeys.contains(KeyCode.ENTER)) {
                    this.stop();
                    BearFruitChallenge.setScene(BearFruitChallenge.CREDITS_SCENE);
                    mediaPlayer.stop();
                } else if (activeKeys.contains(KeyCode.LEFT)) {
                    bear.move(MainCharacter.LEFT);
                } else if (activeKeys.contains(KeyCode.RIGHT)) {
                    bear.move(MainCharacter.RIGHT);
                }
                 //Generate fruit
                if(fruit == null){
                    fruit = new Fruit();
                    fruit.moveTo((int)(Math.random() * (GeneralScene.GAME_WIDTH
                        - Fruit.FRUIT_WIDTH)), 0);
                } else {
                    fruit.move();
                    if(fruit.collidesWith(bear)) {
                        playEffect(SOUND_EFFECT);
                        fruit = null;
                    } else if(fruit.getY() > GeneralScene.GAME_HEIGHT){
                        fruit = null;
                    }
                }
            }
        }.start();
    }

    private void playEffect(String path){
        effect = new Media(new File(path).toURI().toString());
        mediaPlayerEffects = new MediaPlayer(effect);
        mediaPlayerEffects.play();
    }
}