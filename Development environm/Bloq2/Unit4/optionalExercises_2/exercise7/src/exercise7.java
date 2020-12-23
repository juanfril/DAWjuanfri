/*Juan Fco. Losa Márquez
Function called writeName that shows a text received as a parameter with
these characteristics:
- Every character must be in lower case.
- The first character and every character after a non-alphabetic character must be in
upper case.
- The non alphabetic characters must be deleted.*/

public class exercise7 {
    static String wirteName(String source){

        char[] modified = source.toLowerCase().toCharArray();
        modified[0] = Character.toUpperCase(modified[0]);
        
        for(int i = 0; i < (source.length() - 1); i++){
            
            if((modified[i] < 'a' && modified[i] > 'z') || modified[i] == ' '
            && (modified[i + 1] > 'a' && modified[i + 1] < 'z')){

                    modified[i + 1] = Character.toUpperCase(modified[i + 1]);
                }
        }
        return source = new String(modified).replaceAll("[^A-Za-z0-9]","");
    }

    public static void main(String[] args) throws Exception {
        System.out.println(wirteName("HELLO. today is The day."));
        System.out.println(wirteName("I'M TRYING TO BE GOOD. I STUDY EVERY DAY."));
        System.out.println(wirteName("i lovE DeBElop. i WisH To wOrk SomeDay iN ThaT."));
    }
}
