package ficheros.objetos;

public class Person {
    String age;
    String name;
    String weight;

    public Person(){
        age = "0";
        name = "nobody";
        weight = "0";
    }

    public Person( String name, String age, String weight ) {
        this.age = age;
        this.name = name;
        this.weight = weight;
    }

    public String getAge() {
        return age;
    }

    public void setAge( String age ) {
        this.age = age;
    }

    public String getName() {
        return name;
    }

    public void setName( String name ) {
        this.name = name;
    }

    public String getWeight() {
        return weight;
    }

    public void setWeight( String weight ) {
        this.weight = weight;
    }

    @Override
    public String toString(){
        return name + "has " + age + " years old, and his weight is " + weight;
    }
}
