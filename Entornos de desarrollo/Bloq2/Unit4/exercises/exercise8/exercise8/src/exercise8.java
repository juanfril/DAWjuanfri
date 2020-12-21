import java.util.Scanner;

public class exercise8 {
    public static String nameSurname(String name, String surname){
        String modified = "Mr/Ms " + surname + ", "+ name;
        return modified;
    }
    public static void main(String[] args) throws Exception {
        Scanner sc = new Scanner(System.in);
        String name, surname;
        name = sc.next();
        surname = sc.next();
        sc.close();
        System.out.println(nameSurname(name, surname));
    }
}
