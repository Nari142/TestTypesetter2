using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickSaturday : MonoBehaviour
{
    private int count = 0;
    private void OnMouseDown()
    {
        if (count == 0)
        {
            GetComponentInParent<Pick_Manager>().PickSaturday = true;
            count = 1;
        }
        else if (count == 1)
        {
            GetComponentInParent<Pick_Manager>().PickSaturday = false;
            count = 0;
        }
    }
}
