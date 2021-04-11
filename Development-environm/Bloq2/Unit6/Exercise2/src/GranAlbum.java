public class GranAlbum extends FotoAlbum{
    public GranAlbum(){
        super();
        this.pageNumber = 64;
    }

    @Override
    public String toString(){
        return super.toString() + "And I'm big";
    }
}
