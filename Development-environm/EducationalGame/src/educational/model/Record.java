package educational.model;

import java.util.ArrayList;

public abstract class Record {
    protected String name;
    protected int record;

    public Record(String name, int record) {
        this.name = name;
        this.record = record;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getRecord() {
        return record;
    }

    public void setRecord(int record) {
        this.record = record;
    }
    @Override
    public String toString() {
        return  name + ";" + record;
    }

    public static class SumsRecord extends Record{

        public SumsRecord(String name, int record) {
            super(name, record);
        }

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
        @Override
        public String toString(){
            return super.toString() + ";Sums Record";
        }
    }

    public static class SubtractRecord extends Record{

        public SubtractRecord(String name, int record) {
            super(name, record);
        }
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
        @Override
        public String toString(){
            return super.toString() + ";Subtract Record";
        }
    }
    public static class SubtractWithCarriedRecord extends Record{

        public SubtractWithCarriedRecord(String name, int record) {
            super(name, record);
        }

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
        @Override
        public String toString(){
            return super.toString() + ";Subtract With Carried Record";
        }
    }
    public static class MouseRecord extends Record{

        public MouseRecord(String name, int record) {
            super(name, record);
        }

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
        @Override
        public String toString(){
            return super.toString() + ";Mouse Record";
        }
    }
    public static class HowManyRecord extends Record{

        public HowManyRecord(String name, int record) {
            super(name, record);
        }

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
        @Override
        public String toString(){
            return super.toString() + ";How Many Record";
        }
    }
}
