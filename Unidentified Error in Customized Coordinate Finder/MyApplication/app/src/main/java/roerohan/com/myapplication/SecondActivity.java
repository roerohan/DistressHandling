package roerohan.com.myapplication;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.Button;
import android.widget.TextView;

public class SecondActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_second);

        if (getIntent().hasExtra("com.roerohan.MyApplication.SOMETHING")){
            TextView tv = (TextView) findViewById(R.id.textView2);
            String text = getIntent().getExtras().getString("com.roerohan.MyApplication.SOMETHING");
            tv.setText(text);
        }
    }
}
