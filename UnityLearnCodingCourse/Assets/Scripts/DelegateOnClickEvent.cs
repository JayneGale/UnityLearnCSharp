using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class DelegateOnClickEvent : MonoBehaviour
{
    //create a void delegate that calculates the sum of two numbers
    //use a lambda to avoid having a dedicated method 

    public Action<int, int> Sum2Nums;

    public delegate void ActionOnHitH();
    public static event ActionOnHitH onHitH;
    public int a,b,c;

    private void Start()
    {
        Sum2Nums = (a, b) => c = a + b; //one line method via a Lambda expression or can create entire method using {}
        a = 6;
        b = 3;
        Sum2Nums(a, b);
        Debug.Log("Sum of " + a + " and " + b + " = " + c);
    }

    public void HitH()
    {
        if (onHitH != null)
        {
            onHitH();
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            onHitH();
        }
    }

}

