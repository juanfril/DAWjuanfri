/*Juan Fco. Losa Márquez
Function called suitableString that receives a String as a parameter and it has
to return a new String that is like the String passed as parameter but in lower
case except the first character that must be in upper case and every other
character after a point has to be in upper case as well.*/

public class exercise6 {

    static String suitableString(String source){

        char[] modified = source.toLowerCase().toCharArray();
        modified[0] = Character.toUpperCase(modified[0]);
        
        for(int i = 0; i < (source.length()); i++){
            
            if(modified[i] == ' ' && modified[i -1] == '.')
                modified[i + 1] = Character.toUpperCase(modified[i + 1]);
        }
        return new String(modified);
    }

    public static void main(String[] args) throws Exception {
        System.out.println(suitableString("HELLO. today is The day."));
        System.out.println(suitableString("I'M TRYING TO BE GOOD." +
            "I STUDY EVERY DAY."));
        System.out.println(suitableString("i lovE DeBElop. i WisH To wOrk" + 
            "SomeDay iN ThaT."));
    }
}
