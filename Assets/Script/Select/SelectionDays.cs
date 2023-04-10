using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionDays : MonoBehaviour
{

    private void OnMouseDown()
    {
        GetComponentInParent<Selection_Script>().Selection_Alarm = false;
        GetComponentInParent<Selection_Script>().Selection_Day = true;
        GetComponentInParent<Selection_Script>().Selection_Melody = false;
        GetComponentInParent<Selection_Script>().Selection_Tasks = false;
    }

}
