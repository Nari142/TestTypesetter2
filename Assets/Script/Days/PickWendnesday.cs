using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickWendnesday : MonoBehaviour
{
    private int count = 0;
    private void OnMouseDown()
    {
        if (count == 0)
        {
            GetComponentInParent<Pick_Manager>().PickWednesday = true;
            count = 1;
        }
        else if (count == 1)
        {
            GetComponentInParent<Pick_Manager>().PickWednesday = false;
            count = 0;
        }
    }
}
