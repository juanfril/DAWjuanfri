/*Juan Fco.Losa Márquez
List of circulars prime numbers betwen two parameters*/

public class App {
    public static boolean circularNumber(int number){
        boolean isCircular = true;
        boolean prime = true;
        String tempNumber = String.valueOf(number);
        String tempCircular = "";
        int count = tempNumber.length();
        
        while(count != 0 && prime){

            tempCircular = "";

            for (int i = 0; i < tempNumber.length() -1; i++){
                tempCircular = tempCircular + tempNumber.charAt(i + 1);
            }
            tempCircular = tempCircular + tempNumber.charAt(0);

            number = Integer.valueOf(tempCircular);

            for(int i = 2; i < number && prime; i++){
                if(number % i == 0){
                    prime = false;
                    isCircular = false;
                    count = 0;
                }
            }

            tempNumber = String.valueOf(number);
            count--;
        }
        return isCircular;
    }
    public static void main(String[] args) throws Exception {

        for(int i = 5000; i< 15000; i++){
            if(circularNumber(i))
                System.out.println(i);
            else
                System.out.println("No results");
        }

        
    }
}

