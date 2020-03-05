using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool_Manager : MonoBehaviour
{
    private static Pool_Manager _instance;
    public static Pool_Manager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("The Pool Manager is NULL");
            return _instance;
        }
    }

    [SerializeField]
    private GameObject _wallContainer;
    [SerializeField]
    private GameObject _wallPrefab;
    [SerializeField]
    private List<GameObject> _wallsPool;

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        _wallsPool = GenerateWalls(10);     
    }

    List<GameObject> GenerateWalls(int numWalls)
    {
        for (int i=0; i < numWalls; i++)
        {
            GameObject wall = Instantiate(_wallPrefab);
            wall.transform.parent = _wallContainer.transform;
            wall.SetActive(false);
            _wallsPool.Add(wall);
        }
        return _wallsPool;
    }

    public GameObject RequestWall()
    {
        int j = _wallsPool.Count;
        for (int i=0; i < j; i++)
        {
            if (!_wallsPool[i].activeInHierarchy)
            {
                _wallsPool[i].SetActive(true);
                return _wallsPool[i];
            }
            //set a wall Active
            //loop through the wall list until we find an inactive bullet
            //found one, setActive and return it to Player
        }
        //if none, instantiate x more walls on the fly, and run the request wall method again
        GameObject newWall = Instantiate(_wallPrefab);
        newWall.transform.parent = _wallContainer.transform;
        _wallsPool.Add(newWall);
        return newWall;
    }
}
    
