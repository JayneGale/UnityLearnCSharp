using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportDelegate : MonoBehaviour
{
    void Start()
    {
        DelegateOnClickEvent.onHitH += Teleport;
    }

    private void Teleport()
    {
        transform.position = new Vector3(5,2,0);
        
    }

    private void OnDisable()
    {
        DelegateOnClickEvent.onHitH -= Teleport;
    }
}
