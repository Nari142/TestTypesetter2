using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionAlarm : MonoBehaviour
{

    private void OnMouseDown()
    {
            GetComponentInParent<Selection_Script>().Selection_Alarm = true;
            GetComponentInParent<Selection_Script>().Selection_Day = false;
            GetComponentInParent<Selection_Script>().Selection_Melody = false;
            GetComponentInParent<Selection_Script>().Selection_Tasks = false;        
    }


}
