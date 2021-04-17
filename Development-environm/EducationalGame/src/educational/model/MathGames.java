package educational.model;

import educational.controller.GeneralController;

import java.util.Random;

public abstract class MathGames {
    protected byte number1;
    protected byte number2;
    protected Random random = new Random();

    public MathGames() {}

    protected abstract void mathOperation();
}
