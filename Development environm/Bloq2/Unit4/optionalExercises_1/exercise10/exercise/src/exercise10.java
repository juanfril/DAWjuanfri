/*Juan Fco.Losa Márquez
Function that returns if a number is Circular prime or not. A Circular
prime number is the number that is prime in every rotation of their digits. For
example: 1193 is circular prime because 1931,9311,3119 and 1193 are prime
numbers.*/

public class exercise10 {
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

            System.out.println("Número rotado " + number);

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
        int number = 1193;

        if(circularNumber(number))
            System.out.println(number + " is a circular number");

        else
            System.out.println(number + " isn't a circular number");
    }
}
