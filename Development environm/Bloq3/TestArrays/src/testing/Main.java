package testing;

import java.util.ArrayList;

public class Main {
    public static class Person{
        String name;
        int age;
        int weight;

        public Person(){
            name = "none";
            age = 0;
            weight = 0;
        }

        public Person(String name, int age, int weight) {
            this.name = name;
            this.age = age;
            this.weight = weight;
        }

        public String getName() {
            return name;
        }

        public void setName(String name) {
            this.name = name;
        }

        public int getAge() {
            return age;
        }

        public void setAge(int age) {
            this.age = age;
        }

        public int getWeight() {
            return weight;
        }

        public void setWeight(int weight) {
            this.weight = weight;
        }

        @Override
        public String toString(){
            return name + " is " + age + " and his weight is " + weight;
        }
    }

    public ArrayList<Person> loadFile(){
        ArrayList<Person> person = new ArrayList<>();



        return person;
    }

    public static void main(String[] args) {
        Person p = new Person("Juanfri", 39, 85);
        Person o = new Person("Oliver", 8, 25);
        Person c = new Person("Cristina", 38, 65);

        ArrayList<Person> list = new ArrayList<>();
        list.add(p);
        list.add(o);
        list.add(c);

        for (Person pe : list){
            System.out.println(pe);
        }
    }
}
