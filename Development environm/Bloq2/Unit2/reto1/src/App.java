import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        Scanner entrada = new Scanner(System.in);
        int pruebas = entrada.nextInt();
        final int limiteCaracteres = 100;
        String nombre = "";
        String parentesco = "";

        for(int i = 0; i < pruebas; i++){
            
            do{
                nombre = entrada.next();
                parentesco = entrada.next().replace(" ", "");

                if(nombre.equals("Luke") && parentesco.equals("padre")){
                    System.out.println("TOP SECRET");
                }
                else{
                    System.out.println(nombre + " yo soy tu " + parentesco);
                }
            }while(nombre.length() > limiteCaracteres || parentesco.length() > limiteCaracteres);
        }
    }
}
