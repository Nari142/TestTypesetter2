using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melody_Manager : MonoBehaviour
{
    public GameObject Pick_Melody1;
    public GameObject Pick_Melody2;
    public GameObject Pick_Melody3;
    public GameObject Pick_Melody4;
    public GameObject Pick_Melody5;
    public GameObject Pick_Melody6;
    public GameObject Pick_Melody7;

    public bool PickMelody1;
    public bool PickMelody2;
    public bool PickMelody3;
    public bool PickMelody4;
    public bool PickMelody5;
    public bool PickMelody6;
    public bool PickMelody7;

    void Start()
    {
        PickMelody1 = false;
        PickMelody2 = false;
        PickMelody3 = false;
        PickMelody4 = false;
        PickMelody5 = false;
        PickMelody6 = false;
        PickMelody7 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PickMelody1 == false){
            Pick_Melody1.SetActive(false);
        }
        else{
            Pick_Melody1.SetActive(true);
        }
        if (PickMelody2 == false)
        {
            Pick_Melody2.SetActive(false);
        }
        else
        {
            Pick_Melody2.SetActive(true);
        }
        if (PickMelody3 == false)
        {
            Pick_Melody3.SetActive(false);
        }
        else
        {
            Pick_Melody3.SetActive(true);
        }
        if (PickMelody4 == false)
        {
            Pick_Melody4.SetActive(false);
        }
        else
        {
            Pick_Melody4.SetActive(true);
        }
        if (PickMelody5 == false)
        {
            Pick_Melody5.SetActive(false);
        }
        else
        {
            Pick_Melody5.SetActive(true);
        }
        if (PickMelody6 == false)
        {
            Pick_Melody6.SetActive(false);
        }
        else
        {
            Pick_Melody6.SetActive(true);
        }
        if (PickMelody7 == false)
        {
            Pick_Melody7.SetActive(false);
        }
        else
        {
            Pick_Melody7.SetActive(true);
        }
    }
}
