/*Juan Fco. Losa Márquez
--Compulsoty exercise--
Two games for play in console. A lottery game, and a play versus
machine that substratc chip to pending 0*/

public class Games {
    public static void main(String[] args) throws Exception {
        int[] winner = generateLottery();
        System.out.println(generateNumber(1, 4));
        for(int i : winner)
            System.out.print(i + " ");
    }

    public static int generateNumber(int min, int max){
        return (int)Math.floor(Math.random()*(min-max) + max);
    }

    public static int[] generateLottery(){
        int[] sixNumbers = new int[6];
        for(int i = 0; i < 6; i++){
            sixNumbers[i] = generateNumber(1 , 50);
            
            for(int j = i; j >= i; j--){
                do{
                    if(sixNumbers[i] == sixNumbers[j])
                        sixNumbers[j] = generateNumber(1 , 50);
                }
                while(sixNumbers[i] == sixNumbers[j] && sixNumbers.length < 1);
            }
        }
        return sixNumbers;
    }

    /*public static int[] checkLottery(int[] user, int[] winner){

    }*/
    
    static void playNim(){

    }

    static void playLottery(){

    }
}
