using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWallsClass : MonoBehaviour
{
    public void DestroyWalls()
    {
        Destroy(this.gameObject, 1.0f);
    }
}
