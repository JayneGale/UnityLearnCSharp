using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclareProperties : MonoBehaviour
{
    //speed readonly
    //name public
    public float Speed { get; private set; }
    //private float speed = 10.0f;
    //public float Speed
    //{
    //    get
    //    {
    //        return speed;
    //    }
    //    private set
    //    {
    //        speed = value;
    //    }
    //}

    private string _name = "error type 1";
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
        

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Set speed to 1" + Speed + speed);
        speed = 5.0f;
        SetSpeed();
        Debug.Log("Set name to 2 " + Name);
        _name = "error type 2";
        Debug.Log("Set name to 3 " + Name);
        SetName();
        Debug.Log("Set name to 5" + Name);

    }

    void SetSpeed()
    {
        Debug.Log("Set speed to 2 " + Speed + speed);
        speed = 15.0f;
        Debug.Log("Set speed to 3 " + Speed + speed);
    }

    private void SetName()
    {
        Debug.Log("Set name to 4" + Name);
        Name = "Cindy Lauper";
    }
}
