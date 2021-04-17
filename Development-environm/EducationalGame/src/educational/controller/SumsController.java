package educational.controller;

import javafx.fxml.FXML;
import javafx.scene.control.Button;

import java.net.URL;
import java.util.Random;
import java.util.ResourceBundle;

import javafx.scene.control.Label;
import javafx.scene.control.TextField;

public class SumsController extends GeneralController {

    @FXML
    private Label lbNumber1;
    @FXML
    private Label lbNumber2;
    @FXML
    private TextField txtResult;
    @FXML
    private Button btnResult;
    private Random random = new Random();
    private int number1, number2, result;

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        number1 = (int)(Math.floor(Math.random()*(0-1000+1)+1000));
        number2 = (int)(Math.floor(Math.random()*(0-1000+1)+1000));

        lbNumber1.setText(String.valueOf(number1));
        lbNumber2.setText(String.valueOf(number2));

        btnResult.setOnAction(actionEvent -> {
            try{
                do{
                    result = Integer.parseInt(txtResult.getText());
                    if(result == number1 + number2){
                        dialog.setHeaderText("Information");
                        dialog.setContentText("Correct");
                        dialog.showAndWait();

                        number1 = (int)(Math.floor(Math.random()*(0-1000+1)+1000));
                        number2 = (int)(Math.floor(Math.random()*(0-1000+1)+1000));

                        lbNumber1.setText(String.valueOf(number1));
                        lbNumber2.setText(String.valueOf(number2));
                    } else{
                        dialog.setHeaderText("Information");
                        dialog.setContentText("You fail");
                        dialog.showAndWait();
                    }
                }while(result == number1 + number2);
            } catch (Exception e) {
                dialog.setHeaderText("Information");
                dialog.setContentText(String.valueOf(e));
                dialog.showAndWait();
            }
        });
    }
}
