using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTasks : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponentInParent<Tasks_Manager>().PickWashing = false;
        GetComponentInParent<Tasks_Manager>().PickBreakfast = false;
        GetComponentInParent<Tasks_Manager>().PickCartoon = false;
        GetComponentInParent<Tasks_Manager>().PickDRessing = false;
        GetComponentInParent<Tasks_Manager>().PickCharger = false;
        GetComponentInParent<Tasks_Manager>().PickWalk = false;
    }
}
