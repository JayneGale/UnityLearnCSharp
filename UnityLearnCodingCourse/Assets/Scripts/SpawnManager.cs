using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private static SpawnManager _instance;
    public static SpawnManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("SpawnManager is NULL");
            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;

    }
    [SerializeField]
    private GameObject _enemyPrefab;

    public void StartSpawning()
    {
        print("Spawn started");
        Instantiate(_enemyPrefab);
    }

    private void Start()
    {
        Debug.Log(Player.Instance.name);
    }
}
