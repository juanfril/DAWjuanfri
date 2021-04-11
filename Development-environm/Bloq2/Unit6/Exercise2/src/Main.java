public class Main {
    public static void main(String[]args){
        FotoAlbum myAlbum[] = new FotoAlbum[4];

        for (int i = 0; i < myAlbum.length; i++) {
            if (i < 2) {
                myAlbum[i] = new FotoAlbum();
            }
            else {
                myAlbum[i] = new GranAlbum();
            }
        }
        for (FotoAlbum p : myAlbum) {
            System.out.println(p);
        }
    }
}



