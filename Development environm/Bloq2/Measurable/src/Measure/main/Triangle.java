package Measure.main;

public class Triangle extends GeometricalFigure implements
    Measurable, Drawable{

    private int size;

    @Override
    public void draw() {

    }

    @Override
    public String show() {
        return "I'm a triangle and my size is: " + size;
    }

    @Override
    public int getSize() {
        return size; //calculate the size
    }
}
