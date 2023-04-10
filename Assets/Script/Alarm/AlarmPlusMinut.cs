using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmPlusMinut : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponentInParent<Alarm_Manager>().Minutes += 1;
    }
}
