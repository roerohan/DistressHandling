package com.example.vishaal.distresshandler;

import android.animation.ObjectAnimator;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ProgressBar;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {
    boolean flagHostile=false;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        hideAlert();
    }
    public void btn_onClick(View view){

        if(flagHostile){
            //Send Distress
        }else{
            //Notify user that the area is not hostile
        }
    }

  //for alerting the user by showing a indeterminate circular progressbar.
    private void showAlert(){
        ProgressBar pb=(ProgressBar)findViewById(R.id.progressBar);
        pb.setVisibility(View.VISIBLE);
        flagHostile=true;
    }
    private void hideAlert(){
        ProgressBar pb=(ProgressBar)findViewById(R.id.progressBar);
        pb.setVisibility(View.INVISIBLE);
        flagHostile=false;
    }

}
