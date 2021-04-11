package house.main;

public class Person {
    private String name;
    SmallApartment apartment;

    public Person(String name){
        this.name = name;
        apartment = new SmallApartment();
    }

    public void setName(String name) {
        this.name = name;
    }

    @Override
    public String toString(){
        return "My name is" + name + " | " + apartment + " | " + apartment.door;
    }
}
