using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour
{
    KeyCode[] _keys = { KeyCode.Alpha1,KeyCode.Alpha2, KeyCode.Alpha3, KeyCode.Alpha4, KeyCode.Alpha5, KeyCode.Alpha6}; //keys 1-6 inclusive
    Color[] _cols = {Color.red, Color.yellow, Color.green, Color.cyan, Color.blue, Color.magenta}; // 6 colours 
    Material _mat; //set only works on material property not on the colour sub-property
    Color _cubeCol;  
    int _keyIndex;

    // Start is called before the first frame update
    void Start()
    {
        _mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < _keys.Length; i++)
        {
            if (Input.GetKeyDown(_keys[i]))
            {
                _keyIndex = i;
                SwitchColour(_keyIndex);
                break; //stop after finding a key pressed;
            }
        }

    }

    private void SwitchColour(int keyIndex)
    {
        switch (keyIndex)
        {
            case 0: //key 0
                _cubeCol = _cols[0];
                print("1 key pressed gives " + _cubeCol);
                break;
            case 1: // key 1
                _cubeCol = _cols[1];
                print("2 key pressed gives colour " + _cubeCol.ToString());
                break;
            case 2:
                _cubeCol = _cols[2];
                print("3 key pressed gives colour " + _cubeCol.ToString());
                break;
            case 3:
                _cubeCol = _cols[3];
                print("4 key pressed gives colour " + _cubeCol.ToString());
                break;
            case 4:
                _cubeCol = _cols[4];
                print("5 key pressed gives colour " + _cubeCol.ToString());
                break;
            case 5:
                _cubeCol = _cols[5];
                print("6 key pressed gives colour " + _cubeCol.ToString());
                break;
            default:
                {
                    print("Not a valid keyCode index " + keyIndex);
                    break;
                }
        }
        _mat.color = _cubeCol;
    }
}
