using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickThursday : MonoBehaviour
{
    private int count = 0;
    private void OnMouseDown()
    {
        if (count == 0)
        {
            GetComponentInParent<Pick_Manager>().PickThursday = true;
            count = 1;
        }
        else if (count == 1)
        {
            GetComponentInParent<Pick_Manager>().PickThursday = false;
            count = 0;
        }
    }
}
