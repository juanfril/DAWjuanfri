package educational.model;

import java.util.ArrayList;

/**
 * SuperClass for save records
 */
public abstract class Record {
    protected String name;
    protected int record;

    /**
     * Constructor with parameters
     * @param name A string with the player name
     * @param record A integer for record number
     */
    public Record(String name, int record) {
        this.name = name;
        this.record = record;
    }
    /**
     * Establishes player's name
     * @param name String with name into MainScene
     */
    public void setName(String name) {
        this.name = name;
    }
    /**
     * Method get for player's record
     * @return A int with player's record
     */
    public int getRecord() {
        return record;
    }

    /**
     * Establishes player's record
     * @param record A int with player's record
     */
    public void setRecord(int record) {
        this.record = record;
    }

    /**
     * toString method for Record class
     * @return A string with two properties split for ";"
     */
    @Override
    public String toString() {
        return  name + ";" + record;
    }

    /**
     * Class that inheritance from Record
     * @see Record
     */
    public static class SumsRecord extends Record{
        /**
         * Constructor with parameters
         * @param name A string with the player name
         * @param record A integer for record number
         */
        public SumsRecord(String name, int record) {
            super(name, record);
        }

        /**
         * Static method that check if the player has a new record
         * @param name player's name
         * @param number A number for check
         * @param records A ArrayList with all the records
         * @return A boolean returns true if the number is greater
         */
        public static boolean checkSumsRecord(String name ,int number, ArrayList<Record> records){
            boolean newRecord = false;
            for (int i = 0; i < records.size(); i++) {
                if(records.get(i) instanceof SumsRecord){
                    if(number > records.get(i).getRecord()){
                        newRecord = true;
                        records.get(i).setRecord(number);
                        records.get(i).setName(name);
                        FileUtils.saveRecords(records);
                    }
                }
            }
            return newRecord;
        }

        /**
         * toString method for SumsRecord
         * @return A string with parameters splits with ";" and the name class
         */
        @Override
        public String toString(){
            return super.toString() + ";Sums Record";
        }
    }
    /**
     * Class that inheritance from Record
     * @see Record
     */
    public static class SubtractRecord extends Record{
        /**
         * Constructor with parameters
         * @param name A string with the player name
         * @param record A integer for record number
         */
        public SubtractRecord(String name, int record) {
            super(name, record);
        }
        /**
         * Static method that check if the player has a new record
         * @param name player's name
         * @param number A number for check
         * @param records A ArrayList with all the records
         * @return A boolean returns true if the number is greater
         */
        public static boolean checkSubtractRecord(String name ,int number, ArrayList<Record> records){
            boolean newRecord = false;
            for (int i = 0; i < records.size(); i++) {
                if(records.get(i) instanceof SubtractRecord){
                    if(number > records.get(i).getRecord()){
                        newRecord = true;
                        records.get(i).setRecord(number);
                        records.get(i).setName(name);
                        FileUtils.saveRecords(records);
                    }
                }
            }
            return newRecord;
        }
        /**
         * toString method for SumsRecord
         * @return A string with parameters splits with ";" and the name class
         */
        @Override
        public String toString(){
            return super.toString() + ";Subtract Record";
        }
    }
    /**
     * Class that inheritance from Record
     * @see Record
     */
    public static class SubtractWithCarriedRecord extends Record{
        /**
         * Constructor with parameters
         * @param name A string with the player name
         * @param record A integer for record number
         */
        public SubtractWithCarriedRecord(String name, int record) {
            super(name, record);
        }
        /**
         * Static method that check if the player has a new record
         * @param name player's name
         * @param number A number for check
         * @param records A ArrayList with all the records
         * @return A boolean returns true if the number is greater
         */
        public static boolean checkSubtractWithCarriedRecord(String name ,int number, ArrayList<Record> records){
            boolean newRecord = false;
            for (int i = 0; i < records.size(); i++) {
                if(records.get(i) instanceof SubtractWithCarriedRecord){
                    if(number > records.get(i).getRecord()){
                        newRecord = true;
                        records.get(i).setRecord(number);
                        records.get(i).setName(name);
                        FileUtils.saveRecords(records);
                    }
                }
            }
            return newRecord;
        }
        /**
         * toString method for SumsRecord
         * @return A string with parameters splits with ";" and the name class
         */
        @Override
        public String toString(){
            return super.toString() + ";Subtract With Carried Record";
        }
    }
    /**
     * Class that inheritance from Record
     * @see Record
     */
    public static class MouseRecord extends Record{
        /**
         * Constructor with parameters
         * @param name A string with the player name
         * @param record A integer for record number
         */
        public MouseRecord(String name, int record) {
            super(name, record);
        }
        /**
         * Static method that check if the player has a new record
         * @param name player's name
         * @param number A number for check
         * @param records A ArrayList with all the records
         * @return A boolean returns true if the number is greater
         */
        public static boolean checkMouseRecord(String name ,int number, ArrayList<Record> records){
            boolean newRecord = false;
            for (int i = 0; i < records.size(); i++) {
                if(records.get(i) instanceof MouseRecord){
                    if(number > records.get(i).getRecord()){
                        newRecord = true;
                        records.get(i).setRecord(number);
                        records.get(i).setName(name);
                        FileUtils.saveRecords(records);
                    }
                }
            }
            return newRecord;
        }
        /**
         * toString method for SumsRecord
         * @return A string with parameters splits with ";" and the name class
         */
        @Override
        public String toString(){
            return super.toString() + ";Mouse Record";
        }
    }
    /**
     * Class that inheritance from Record
     * @see Record
     */
    public static class HowManyRecord extends Record{
        /**
         * Constructor with parameters
         * @param name A string with the player name
         * @param record A integer for record number
         */
        public HowManyRecord(String name, int record) {
            super(name, record);
        }
        /**
         * Static method that check if the player has a new record
         * @param name player's name
         * @param number A number for check
         * @param records A ArrayList with all the records
         * @return A boolean returns true if the number is greater
         */
        public static boolean checkHowManyRecord(String name ,int number, ArrayList<Record> records){
            boolean newRecord = false;
            for (int i = 0; i < records.size(); i++) {
                if(records.get(i) instanceof HowManyRecord){
                    if(number > records.get(i).getRecord()){
                        newRecord = true;
                        records.get(i).setRecord(number);
                        records.get(i).setName(name);
                        FileUtils.saveRecords(records);
                    }
                }
            }
            return newRecord;
        }
        /**
         * toString method for SumsRecord
         * @return A string with parameters splits with ";" and the name class
         */
        @Override
        public String toString(){
            return super.toString() + ";How Many Record";
        }
    }
}
