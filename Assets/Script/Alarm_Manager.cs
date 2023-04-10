using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Alarm_Manager : MonoBehaviour
{
    public int Clock;
    public int Minutes;

    public TextMeshPro ClocTime;
    public TextMeshPro MinutTime;
    public TextMeshPro TimeText;

    private int countClock;
    private int countMinutes;
    void Start()
    {
        Clock = 0;
        Minutes = 0;
        
    }

    void Update()
    {
        ClockAlarm();
        MinutAlarm();
        ClocTime.text = Clock.ToString();
        MinutTime.text = Minutes.ToString();
        TimeText.SetText("Âנולÿ ןמהתולא " + "" + Clock.ToString() + ":" + Minutes.ToString());
    }
    
    void ClockAlarm()
    {
        if (Clock > 23)
        {
            Clock = 0;
        }
        if (Clock < 0)
        {
            Clock = 23;
        }
    }

    void MinutAlarm()
    {
        if (Minutes > 59)
        {
            Minutes = 0;
        }
        if (Minutes < 0)
        {
            Minutes = 59;
        }
    }
}
