using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroy : MonoBehaviour
{
    public void DestroyWalls()
    {
        Destroy(this.gameObject, 1.0f);
    }
}
