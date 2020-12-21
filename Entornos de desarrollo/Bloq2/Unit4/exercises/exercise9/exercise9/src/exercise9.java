
public class exercise9 {

    public static int addDigits(int parameter) {
        if(parameter==0){
            return 0;
        } 
        else {
            return addDigits(parameter/10) + parameter%10;
        }
    }
    public static void main(String[] args) throws Exception {
        System.out.println(addDigits(123));
    }
}
