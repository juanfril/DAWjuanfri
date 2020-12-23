/*Create a function called isAlphabetic that returns if a char given
as a parameter is an alphabetic character or not (upper and lower incluided)*/

public class exercise1 {

    static boolean isAlphabetic(char letter){

        if(!((letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'z')))
            return false;

        else
            return true;
    }
    public static void main(String[] args) throws Exception {
        
        if(isAlphabetic('1'))
            System.out.println("It is an alphabetic character");
        else
            System.out.println("It is not an alphabetic character");
    }
}
