/*Juan Fco. Losa Márquez
Function called raise(num,n) that raises to a nth power the number num.
Create an iterative version and a recursive version.*/

public class exercise5 {

    static int pow(int a, int b){

        //Iterative

        /*int result = 1;
        for(int i = 1; i <= b; i++)
            result *= a;

        return result;*/

        //recursive

        if(b == 0)
            return 1;
        else
            return a * pow(a, (b -1));
    }
    public static void main(String[] args) throws Exception {
        System.out.println(pow(2, 3));
    }
}
