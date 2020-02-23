using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string itemType;
    public Color itemColor;
    public Sprite itemSprite;
}

public class PrintingNumbers : MonoBehaviour
{
    public GameObject[] cubes;

    //public string[] names;
    //int[] ages = {8, 6, 9, 12, 22};
    //public string[] toys;
    //public int i = 4;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            for (int i = 0; i < cubes.Length; i++)
            {
                ChangeColour(cubes[i], Color.gray);
            }
            //i = Random.Range(0, names.Length);
            //print(names[i] + " age " + ages[i] + " favourite toy " + toys[i]);
        }

        //_maxSpeed = Random.Range(60, 120);
        //print("Max speed is" + _maxSpeed);

        //StartCoroutine(AddSpeedRoutine());

        //for (int i = 0; i < 10; i++) print(i);
        //for (int i = 10; i<= 20; i++)
        //{
        //    if (i % 2 ==0)
        //    {
        //        print(i);
        //    }
        //}

        //for (int i = 21; i <= 30; i++) 
        //{
        //    if (i % 2 == 1)
        //    {
        //        print(i);
        //    }
        //}
    }

    void ChangeColour(GameObject cube, Color colour)
    {
        cube.GetComponent<MeshRenderer>().material.color = colour;
    }


    //IEnumerator AddSpeedRoutine()
    //{
    //    while(_speed < _maxSpeed)            
    //    {
    //        _speed += 5;
    //        print("speed is" + _speed);
    //        yield return new WaitForSeconds(1.0f);
    //    }
    //    print("speed at end of coroutine is" + _speed);

    //}
}
