using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmMinus : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponentInParent<Alarm_Manager>().Clock -= 1;
    }
}
