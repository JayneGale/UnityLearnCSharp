using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListofNames : MonoBehaviour
{
    List<string> listOfNames = new List<string> { "Jon", "Sami", "Jeannette", "Toni", "Vivienne" };
    // Start is called before the first frame update
    void Start()
    {
        foreach(var name in listOfNames)
        {
            print(name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N) && listOfNames.Count>1)
        {
            string nameToRemove = listOfNames[Random.Range(0, listOfNames.Count)];
            print("Name removed = " + nameToRemove);
            listOfNames.Remove(nameToRemove);
            foreach (var name in listOfNames)
            {
                print(name);
            }

        }
    }
}
