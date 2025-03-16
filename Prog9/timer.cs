using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timer : MonoBehaviour
{
    public float timeleft = 300f;
    public Text display;
     void Update()
    {
        timeleft -= Time.deltaTime;
        int min = Mathf.FloorToInt(timeleft / 60);
        int sec = Mathf.FloorToInt(timeleft % 60);
        display.text = "Time Left:" + min.ToString("00") + ":" + sec.ToString("00");
        if(timeleft<=0)
        {
            display.text = "Time Up !!";
            enabled=false;
        }
    }
}