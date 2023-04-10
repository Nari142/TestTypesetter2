using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickWalk : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponentInParent<Tasks_Manager>().PickWalk = true;
    }
}
