using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomObjects : MonoBehaviour
{
    public GameObject[] spawnPrefabs = new GameObject[3];
    public List<GameObject> objectsCreated = new List<GameObject>();
    bool maxSpawn = false;

    private void Start()
    {
        objectsCreated.Clear(); //initialise an empty List
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) && !maxSpawn)   //the list Count is less than 10 and haven't reached the maximum spawn number 10
        {
            var newObject = Instantiate(spawnPrefabs[Random.Range(0, spawnPrefabs.Length)], new Vector3(Random.Range(-10f, 10f), Random.Range(0f, 10f), 0f), Quaternion.identity);
            newObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f)); //set their renderer.material.color to random colour
            objectsCreated.Add(newObject);
            print("objsCreated Count is "+ objectsCreated.Count); // see how that's going
            if (objectsCreated.Count >= 10) //if the list Count is 10 or more
            {
                maxSpawn = true; //maxSpawn is true
                foreach (GameObject obj in objectsCreated)
                {
                    obj.GetComponent<Renderer>().sharedMaterial.color = Color.green; //set their renderer.material.color to green
                }
                objectsCreated.Clear(); //clear the List
            }
        }
    }
}
