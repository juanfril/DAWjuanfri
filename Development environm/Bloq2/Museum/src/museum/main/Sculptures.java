package museum.main;

public class Sculptures extends Artworks{
    private String material;

    public Sculptures(){
        super();
        material = "Stone";
    }

    public String getMaterial() {
        return material;
    }

    public void setMaterial(String material) {
        this.material = material;
    }

    @Override
    public String toString(){
        return super.toString() + " with " + material;
    }
}
