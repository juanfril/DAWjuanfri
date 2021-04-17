package educational.model;

public class Sums extends MathGames{

    public Sums() {
        number1 = (byte) Math.floor(Math.random()*(0-100+1)+100);
        number2 = (byte) Math.floor(Math.random()*(0-100+1)+100);
    }

    @Override
    protected byte mathOperation(byte number1, byte number2) {
        return (byte) (number1 + number2);
    }
}
