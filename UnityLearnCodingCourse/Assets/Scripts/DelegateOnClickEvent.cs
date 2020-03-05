using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class DelegateOnClickEvent : MonoBehaviour
{
    //create a void delegate (hence Action) that calculates the sum of two numbers
    //use a lambda to avoid having a dedicated method 
    //now create a void delegate with no parameters (hence Action) that returns gameObject's name
    //next create a delegate of type int (hence Func not Action) that returns the length of the gamObject's name;
    //last create a delegate of type int that takes 2 numbers as parameters and adds the sum

    public Action<int, int> Sum2Nums;
    public Action onGetName;
    public Func<int> getNameLength;
    public Func<int, int, int> calcSum;

    public delegate void ActionOnHitH();
    public static event ActionOnHitH onHitH;
    public int a,b,c;

    private void Start()
    {
        onGetName = () => Debug.Log("This GameObject name is " + gameObject.name); // an anonymous method, that has no parameters and no returns
        onGetName();
        getNameLength = () => this.gameObject.name.Length;
        int nameLength = getNameLength();
        Debug.Log("Name length is " + nameLength);
        Sum2Nums = (a, b) => c = a + b; //one line method via a Lambda expression or can create entire method using {}
        a = 12;
        b = 1;
        Sum2Nums(a, b);
        Debug.Log("Sum of " + a + " and " + b + " = " + c);

        calcSum = (a, b) => a + b;
        int total = calcSum(9, 3);
        Debug.Log("Total = " + total);
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

    int calcSum0(int a, int b)
    {
        return a + b;
    }

}

