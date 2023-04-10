using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickCharger : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponentInParent<Tasks_Manager>().PickCharger = true;
    }
}
