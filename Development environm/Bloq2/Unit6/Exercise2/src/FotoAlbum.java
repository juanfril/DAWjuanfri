public class FotoAlbum {
    protected int pageNumber;

    public int GetPageNumber(){ return pageNumber; }
    public void SetPageNumber(int p) { pageNumber = p; }

    public FotoAlbum(int pageNumber){
        this.pageNumber = pageNumber;
    }

    public FotoAlbum(){
        pageNumber = 16;
    }

    public String toString(){
        return "I am an album with " + pageNumber + " pages.";
    }
}
