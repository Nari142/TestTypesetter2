using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_Melody4 : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponentInParent<Melody_Manager>().PickMelody1 = false;
        GetComponentInParent<Melody_Manager>().PickMelody2 = false;
        GetComponentInParent<Melody_Manager>().PickMelody3 = false;
        GetComponentInParent<Melody_Manager>().PickMelody4 = true;
        GetComponentInParent<Melody_Manager>().PickMelody5 = false;
        GetComponentInParent<Melody_Manager>().PickMelody6 = false;
        GetComponentInParent<Melody_Manager>().PickMelody7 = false;
    }
}
