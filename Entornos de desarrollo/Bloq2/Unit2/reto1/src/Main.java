import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    
    Scanner entrada = null;
    try{
        entrada = new Scanner(System.in);
        System.out.println("Introduce el número de pruebas");
        int pruebas = entrada.nextInt();
        final int limiteCaracteres = 100;
        String nombre ="";
        String parentesco = "";

        for(int i = 0; i < pruebas; i++){
            do{
                System.out.println("Introduce el nombre del personaje: ");
                nombre = entrada.next().replace(" ", "");

                if(nombre.length() > limiteCaracteres) {
                System.out.println("Número de carácteres máximo 100");
                }

            }while (nombre.length() > limiteCaracteres ||
            nombre.contains(" "));

            do{
                System.out.println("Introduce el parentesco: ");
                parentesco = entrada.next().replace(" ", "");

                if(parentesco.length() > limiteCaracteres){
                    System.out.println("Número de carácteres máximo 100");
                }
                
            }while (parentesco.length() > limiteCaracteres||
            parentesco.contains(" ")); 

            if(nombre.equals("Luke") && parentesco.equals("padre")){
                System.out.println("TOP SECRET");
            }
            else {
                System.out.println(nombre + ", yo soy tu " + parentesco);
            }       
        
        }
    
    }
    finally{
        if(entrada!=null)
            entrada.close();
    }
           
  }
}
