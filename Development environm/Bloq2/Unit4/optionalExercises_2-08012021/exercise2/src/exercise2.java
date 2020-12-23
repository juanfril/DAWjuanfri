/*Juan Fco. Losa Márquez
Function called isAlphabetic that returns is a String given
as a parameter is alphabetic.*/

public class exercise2 {
    static boolean isAlphabetic(String sentence){

        char letter;

        for(int i = 0; i < sentence.length(); i++){
            letter = sentence.charAt(i);
            if(!((letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'z')))
            return false;
        }
            return true;
    }
    public static void main(String[] args) throws Exception {
        
        if(isAlphabetic("Sentence "))
            System.out.println("It is an alphabetic sentence");
        else
            System.out.println("It is not an alphabetic sentence");
    }
}
