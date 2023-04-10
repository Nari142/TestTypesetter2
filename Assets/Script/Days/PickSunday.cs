using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickSunday : MonoBehaviour
{
    private int count = 0;
    private void OnMouseDown()
    {
        if (count == 0)
        {
            GetComponentInParent<Pick_Manager>().PickSunday = true;
            count = 1;
        }
        else if (count == 1)
        {
            GetComponentInParent<Pick_Manager>().PickSunday = false;
            count = 0;
        }
    }
}
