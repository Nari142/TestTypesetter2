using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickTuesday : MonoBehaviour
{
    private int count = 0;
    private void OnMouseDown()
    {
        if (count == 0)
        {
            GetComponentInParent<Pick_Manager>().PickTuesday = true;
            count = 1;
        }
        else if (count == 1)
        {
            GetComponentInParent<Pick_Manager>().PickTuesday = false;
            count = 0;
        }
    }
}
