package educational.controller;

import educational.model.FileUtils;
import educational.model.Record;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.control.ListView;

import java.net.URL;
import java.util.ArrayList;
import java.util.ResourceBundle;

public class ScoreController extends GeneralController{

    @FXML
    private ListView lvRanking;
    private ArrayList<Record> records = new ArrayList<>(FileUtils.loadRecords());

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        lvRanking.cellFactoryProperty();
    }
}
