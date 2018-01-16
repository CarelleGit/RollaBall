using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TimerUI : MonoBehaviour
{

    public Text timerLabel;

    public float duration;
    public bool isRunning;

    void Update()
    {
        if(isRunning) { return; }
        duration -= Time.deltaTime;

        int temp = (int)duration;

        int hours = temp / 60 / 60;
        int minutes = temp / 60;
        int seconds = temp % 60;

        timerLabel.text = hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString();
    }
    public void ToggleTimer()
    {
        isRunning = !isRunning;
    }
}
