package race;

/**
 * Class to represent every stage of the Tour de France
 */

public class CyclingStage {

    private String dateStage; //string with the format yyyy-mm-dd,such as 2021-05-21
    private double totalNumberKm;
    private String winnerFullName;

    public CyclingStage(String dateStage, double totalNumberKm, String winnerFullName) {
        this.dateStage = dateStage;
        this.totalNumberKm = totalNumberKm;
        this.winnerFullName = winnerFullName;
    }

    public String getDateStage() {
        return dateStage;
    }

    public void setDateStage(String dateStage) {
        this.dateStage = dateStage;
    }

    public double getTotalNumberKm() {
        return totalNumberKm;
    }

    public void setTotalNumberKm(double totalNumberKm) {
        this.totalNumberKm = totalNumberKm;
    }

    public String getWinnerFullName() {
        return winnerFullName;
    }

    public void setWinnerFullName(String winnerFullName) {
        this.winnerFullName = winnerFullName;
    }

    @Override
    public String toString() {
        //Example: 2021-05-21 (186 km) Tadej Pogacar
        return  dateStage + " ( " +
                 totalNumberKm +
                " ) " + winnerFullName+"\n";
    }

    @Override
    public boolean equals(Object o) {
        if (o == null || getClass() != o.getClass()) return false;
        return dateStage.equals(((CyclingStage) o).dateStage);
    }

}
