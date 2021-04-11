package race;

public class CyclingStage {
    String date;
    String kilometres;
    String winner;

    public CyclingStage(){
        date = "0000-00-00";
        kilometres = "0";
        winner =  "nobody";
    }

    public CyclingStage( String date, String winner, String kilometres ) {
        this.date = date;
        this.winner = winner;
        this.kilometres = kilometres;
    }

    public String getDate() {
        return date;
    }

    public void setDate( String date ) {
        this.date = date;
    }

    public String getWinner() {
        return winner;
    }

    public void setWinner( String winner ) {
        this.winner = winner;
    }

    public String getKilometres() {
        return kilometres;
    }

    public void setKilometres( String kilometres ) {
        this.kilometres = kilometres;
    }

    @Override
    public String toString(){
        return date + " (" + kilometres + " km) " + winner;
    }
}
