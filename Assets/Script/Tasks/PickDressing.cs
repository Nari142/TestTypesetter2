using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickDressing : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponentInParent<Tasks_Manager>().PickDRessing = true;
    }
}
