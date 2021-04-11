package testing;

import java.io.*;
import java.util.ArrayList;

public class Main {
    public static class Person{
        String name;
        String age;
        String weight;

        public Person(){
            name = "none";
            age = "0";
            weight = "0";
        }

        public Person(String name, String age, String weight) {
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

        public String getAge() {
            return age;
        }

        public void setAge(String age) {
            this.age = age;
        }

        public String getWeight() {
            return weight;
        }

        public void setWeight(String weight) {
            this.weight = weight;
        }

        @Override
        public String toString(){
            return name + " is " + age + " and his weight is " + weight;
        }
    }

    public static ArrayList<Person> loadFile(){
        ArrayList<Person> person = new ArrayList<>();
        String[] AUX = new String[3];

        if (!(new File("test.txt")).exists()){
            System.out.println("File test.txt not found");
        }
        else {
            System.out.println("Reading file...");
        }
        try{
            BufferedReader inputFile = new BufferedReader(
                    new FileReader(new File("test.txt")));

            while (inputFile.readLine() != null){
                AUX = inputFile.readLine().split(";");
                Person p = new Person((String) AUX[0], (String) AUX[1],
                        (String) AUX[2]);
                person.add(p);
            }
        } catch (IOException e){
            System.out.println("There has been some problems: " +
                    e.getMessage());
        }

        System.out.println("File reed.");
        return person;
    }

    public static void main(String[] args) {


        ArrayList<Person> list = loadFile();

        for (Person pe : list){
            System.out.println(pe);
        }

        System.out.println(list.size());
        for (int i = 0; i < list.size(); i++) {
            System.out.println(list.get(i));
        }
    }
}
