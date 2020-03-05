using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWallsClass : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke("HideWalls", 1);
    }
    public void HideWalls()
    {
        this.gameObject.SetActive(false);
        //Destroy(this.gameObject, 1.0f);
    }
}
