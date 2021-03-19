package videogame.sprites;

import javafx.scene.image.Image;

import java.nio.file.Files;
import java.nio.file.Paths;

public class Fruit extends Sprite{
    private static final String IMAGE_PATH = "assets/fruits.png";
    public static int MAX_FRUITS = 2;
    public static int FRUIT_WIDTH = 30;
    public static int FRUIT_HEIGHT = 30;

    public Fruit(){
        this((int)(Math.random() * MAX_FRUITS));
    }

    public Fruit(int fruitType){
        super(FRUIT_WIDTH, FRUIT_HEIGHT);

        try{
            spriteImage = new Image(Files.newInputStream(Paths.get(IMAGE_PATH)));
        }catch (Exception e){
            e.printStackTrace();
        }

        switch (fruitType){
            case 0:
                //Banana
                this.spriteX = 4;
                this.spriteY = 40;
                break;
            case 1:
                //Strawberry
                this.spriteX = 42;
                this.spriteY = 40;
                break;
        }
    }
    public void move(){
        this.y++;
    }
}
