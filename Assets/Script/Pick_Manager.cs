using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_Manager : MonoBehaviour
{
    public GameObject Pick_Monday;
    public GameObject Pick_Tuesday;
    public GameObject Pick_Wednesday;
    public GameObject Pick_Thursday;
    public GameObject Pick_Friday;
    public GameObject Pick_Saturday;
    public GameObject Pick_Sunday;

    public bool PickMonday;
    public bool PickTuesday;
    public bool PickWednesday;
    public bool PickThursday;
    public bool PickFriday;
    public bool PickSaturday;
    public bool PickSunday;

    void Start()
    {
        PickMonday = false;
        PickTuesday = false;
        PickWednesday = false;
        PickThursday = false;
        PickFriday = false;
        PickSaturday = false;
        PickSunday = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PickMonday == false){
            Pick_Monday.SetActive(false);
        }
        else{
            Pick_Monday.SetActive(true);
        }
        if (PickTuesday == false){
            Pick_Tuesday.SetActive(false);
        }
        else{
            Pick_Tuesday.SetActive(true);
        }
        if (PickWednesday == false){
            Pick_Wednesday.SetActive(false);
        }
        else{
            Pick_Wednesday.SetActive(true);
        }
        if (PickThursday == false){
            Pick_Thursday.SetActive(false);
        }
        else{
            Pick_Thursday.SetActive(true);
        }
        if (PickFriday == false){
            Pick_Friday.SetActive(false);
        }
        else{
            Pick_Friday.SetActive(true);
        }
        if (PickSaturday == false){
            Pick_Saturday.SetActive(false);
        }
        else{
            Pick_Saturday.SetActive(true);
        }
        if (PickSunday == false){
            Pick_Sunday.SetActive(false);
        }
        else{
            Pick_Sunday.SetActive(true);
        }
    }
}
