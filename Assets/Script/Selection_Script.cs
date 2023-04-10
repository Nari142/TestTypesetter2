using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Selection_Script : MonoBehaviour
{

    public GameObject SelectionAlarm;
    public GameObject SelectionDay;
    public GameObject SelectionMelody;
    public GameObject SelectionTasks;

    public GameObject RectangleAlarm;
    public GameObject RectangleDays;
    public GameObject RectangleMelody;
    public GameObject RectangleTasks;


    public bool Selection_Alarm = true;
    public bool Selection_Day = false;
    public bool Selection_Melody = false;
    public bool Selection_Tasks = false;

    void Start()
    {
        SelectionAlarm.SetActive(true);
        SelectionDay.SetActive(false);
        SelectionMelody.SetActive(false);
        SelectionTasks.SetActive(false);

        RectangleAlarm.SetActive(true);
        RectangleDays.SetActive(false);
        RectangleMelody.SetActive(false);
        RectangleTasks.SetActive(false);
    }

    void Update()
    {
        Sel();
    }

    void Sel ()
    {
        if (Selection_Alarm == true)
        {


            SelectionAlarm.SetActive(true);
            SelectionDay.SetActive(false);
            SelectionMelody.SetActive(false);
            SelectionTasks.SetActive(false);

            RectangleAlarm.SetActive(true);
            RectangleDays.SetActive(false);
            RectangleMelody.SetActive(false);
            RectangleTasks.SetActive(false);

        }
        if (Selection_Day == true)
        {


            SelectionDay.SetActive(true);
            SelectionAlarm.SetActive(false);
            SelectionMelody.SetActive(false);
            SelectionTasks.SetActive(false);

            RectangleDays.SetActive(true);
            RectangleAlarm.SetActive(false);
            RectangleMelody.SetActive(false);
            RectangleTasks.SetActive(false);

        }
        if (Selection_Melody == true)
        {


            SelectionMelody.SetActive(true);
            SelectionAlarm.SetActive(false);
            SelectionDay.SetActive(false);
            SelectionTasks.SetActive(false);

            RectangleMelody.SetActive(true);
            RectangleAlarm.SetActive(false);
            RectangleDays.SetActive(false);
            RectangleTasks.SetActive(false);

        }
        if (Selection_Tasks == true)
        {


            SelectionTasks.SetActive(true);
            SelectionAlarm.SetActive(false);
            SelectionDay.SetActive(false);
            SelectionMelody.SetActive(false);

            RectangleTasks.SetActive(true);
            RectangleAlarm.SetActive(false);
            RectangleDays.SetActive(false);
            RectangleMelody.SetActive(false);

        }
    }
}
