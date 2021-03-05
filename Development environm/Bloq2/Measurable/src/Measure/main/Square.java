package Measure.main;

public class Square extends GeometricalFigure
        implements Measurable, Drawable {
    private int size;

    @Override
    public String show() {
        return "I'm a square and my size is: " + size;
    }

    @Override
    public int getSize() {
        return size; //calculate the size
    }

    @Override
    public void draw() {

    }
}
