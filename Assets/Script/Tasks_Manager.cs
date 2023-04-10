using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tasks_Manager : MonoBehaviour
{
    public GameObject Pick_Washing;
    public GameObject Pick_Breakfast;
    public GameObject Pick_Cartoon;
    public GameObject Pick_Dressing;
    public GameObject Pick_Charger;
    public GameObject Pick_Walk;

    public bool PickWashing;
    public bool PickBreakfast;
    public bool PickCartoon;
    public bool PickDRessing;
    public bool PickCharger;
    public bool PickWalk;
    
    void Start()
    {
        PickWashing = false;
        PickBreakfast = false;
        PickCartoon = false;
        PickDRessing = false;
        PickCharger = false;
        PickWalk = false;
    }

    void Update()
    {
        if (PickWashing == false)
        {
            Pick_Washing.SetActive(false);
        }
        else
        {
            Pick_Washing.SetActive(true);
        }
        if (PickBreakfast == false)
        {
            Pick_Breakfast.SetActive(false);
        }
        else
        {
            Pick_Breakfast.SetActive(true);
        }
        if (PickCartoon == false)
        {
            Pick_Cartoon.SetActive(false);
        }
        else
        {
            Pick_Cartoon.SetActive(true);
        }
        if (PickDRessing == false)
        {
            Pick_Dressing.SetActive(false);
        }
        else
        {
            Pick_Dressing.SetActive(true);
        }
        if (PickCharger == false)
        {
            Pick_Charger.SetActive(false);
        }
        else
        {
            Pick_Charger.SetActive(true);
        }
        if (PickWalk == false)
        {
            Pick_Walk.SetActive(false);
        }
        else
        {
            Pick_Walk.SetActive(true);
        }
    }
}
