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
            GameObject wall = Pool_Manager.Instance.RequestWall();
            wall.transform.position = new Vector3(1, 5, 0);
            //Instantiate(_wallPrefab);
        }
    }

}
