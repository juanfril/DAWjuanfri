package museum.main;

public abstract class Artworks {
    private String author;
    private String owner;
    private String name;
    private int year;

    public Artworks(){
        author = "Anonymous";
        owner = "Yourself";
        name = "Some";
        year = 1990;
    }

    public String getAuthor() {
        return author;
    }

    public void setAuthor(String author) {
        this.author = author;
    }

    public String getOwner() {
        return owner;
    }

    public void setOwner(String owner) {
        this.owner = owner;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getYear() {
        return year;
    }

    public void setYear(int year) {
        this.year = year;
    }

    @Override
    public String toString(){
        return "Actual owner: " + owner + " |" + name +
                ": made for " + author + " in " + year;
    }
}
