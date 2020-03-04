using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateOnClickEvent : MonoBehaviour
{
    public delegate void ActionOnHitH();
    public static event ActionOnHitH onHitH;

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

