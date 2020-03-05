using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    [SerializeField]
    private GameObject _wallPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(_wallPrefab);
        }
    }

}
