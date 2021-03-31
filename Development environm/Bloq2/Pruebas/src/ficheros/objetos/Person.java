package ficheros.objetos;

public class Person {
    int age;
    String name;
    int weight;

    public Person(){
        age = 0;
        name = "nobody";
        weight = 0;
    }

    public Person( String name, int age, int weight ) {
        this.age = age;
        this.name = name;
        this.weight = weight;
    }

    public int getAge() {
        return age;
    }

    public void setAge( int age ) {
        this.age = age;
    }

    public String getName() {
        return name;
    }

    public void setName( String name ) {
        this.name = name;
    }

    public int getWeight() {
        return weight;
    }

    public void setWeight( Integer weight ) {
        this.weight = weight;
    }

    @Override
    public String toString(){
        return name + "has " + age + " years old, and his weight is " + weight;
    }
}
