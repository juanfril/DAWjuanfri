/*Juan Fco. Losa Márquez
function called writeReverse that shows a text received as a parameter
but reversed. Create an iterative version and a recursive version.*/

public class exercise4 {

    static String writeReverse(String reverse){

        //.reverse()

        StringBuilder reverseBuilder = new StringBuilder(reverse);

        return reverse = reverseBuilder.reverse().toString();

        //Iterative

        /*String sReverse = "";

        for(int i = reverse.length() - 1; i >= 0; i--)
            sReverse = sReverse + reverse.charAt(i);

        return sReverse;*/

        //recursive...don't work jet

        /*if(reverse.length() == 1)
            return reverse;
        else
            return writeReverse(reverse.substring(1)) + charAt(0);*/
    }

	public static void main(String[] args) throws Exception {

        System.out.println(writeReverse("Hola!"));
    }
}
