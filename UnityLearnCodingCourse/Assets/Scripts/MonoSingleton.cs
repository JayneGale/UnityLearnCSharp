using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                string mName = typeof(T).ToString();
                GameObject go = new GameObject(mName);
                go.AddComponent<T>();
                Debug.Log(mName + " was NULL and has been initialised");
            }
            return _instance;
        }
    }
    private void Awake()
    {
        _instance = (T)this;
        Init();// this allows a GM to initialise methods on Awake after it is instantiated using this MonoSingleton approach
     }

    public virtual void Init()
    {
        //optional to override (virtual is optional to use, whereas abstract would force its use)
    }
}
