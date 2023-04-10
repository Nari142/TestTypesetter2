using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickCartoon : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponentInParent<Tasks_Manager>().PickCartoon = true;
    }
}
