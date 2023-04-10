using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickWashing : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        GetComponentInParent<Tasks_Manager>().PickWashing = true;
    }
}
