import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    
    Scanner entrada = null;
    
    entrada = new Scanner(System.in);
    System.out.println("Introduce el número de pruebas");
    int pruebas = entrada.nextInt();
    final int limiteCaracteres = 100;
    String nombre ="";
    String parentesco = "";

    for(int i = 0; i < pruebas; i++){
        do{
            System.out.println("Introduce el nombre y parentesco: ");
            nombre = entrada.next();
            parentesco = entrada.next().replace(" ", "");

            if(nombre.length() > limiteCaracteres || parentesco.length() > limiteCaracteres) {
            System.out.println("Número de carácteres máximo 100");
            }

        }while (nombre.length() > limiteCaracteres ||
        nombre.contains(" ") || parentesco.contains(" ") || parentesco.length() > limiteCaracteres);
        
        if(nombre.equals("Luke") && parentesco.equals("padre")){
            System.out.println("TOP SECRET");
        }
        else {
            System.out.println(nombre + ", yo soy tu " + parentesco);
        }        
    }             
  }
}
