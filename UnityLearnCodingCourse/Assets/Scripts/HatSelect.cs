using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatSelect : MonoBehaviour
{
    public int hatID = 3;
    int[] _hatID = { 1, 2, 3 };
    //_ID 1 = feather hat
    //_ID 2 = straw hat
    //_ID 3 = fascinator

    void Start()
    {
        switch (hatID)
        {
            case 1: 
                print("Feather hat selected");
                break;
            case 2:
                print("Straw hat selected");
                break;
            case 3:
                print("Fascinator selected");
                break;
            default:
                print("Invalid hat ID");
                break;
        }
    }
}
