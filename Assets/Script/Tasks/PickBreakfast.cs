using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickBreakfast : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        GetComponentInParent<Tasks_Manager>().PickBreakfast = true;
    }
}
