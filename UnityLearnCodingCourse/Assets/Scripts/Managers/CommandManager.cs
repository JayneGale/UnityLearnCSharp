using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CommandManager : MonoBehaviour
{
    private static CommandManager _instance;
    public static CommandManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.LogError("The Command Manager is null");
            }
            return _instance;
        }
    }

    public List<ICommands> _commandBuffer = new List<ICommands>();

    private void Awake()
    {
        _instance = this;
    }

    public void AddBuffer(ICommands command)
    {
        _commandBuffer.Add(command);
    }

    public void PlayCommands()
    {
        StartCoroutine(PlayRoutine());
        //play the commandBuffer list of commands for the number of commands in the commandBuffer
    }

    IEnumerator PlayRoutine()
    {
        foreach (ICommands command in _commandBuffer)
        {
            command.Execute();
            yield return new WaitForEndOfFrame();

            //yield return new WaitForSeconds(1.0f);
        }
    }

    public void RewindCommands()
    {
        StartCoroutine(RewindRoutine());
    }

    IEnumerator RewindRoutine()
    {
        foreach (ICommands command in Enumerable.Reverse(_commandBuffer))
        //for (int i = _commandBuffer.Count - 1; i <= 0; i--)
        {
            command.Undo();
            //_commandBuffer[i].Execute();
            //yield return new WaitForSeconds(1.0f);
            yield return new WaitForEndOfFrame();

        }
    }

    public void DoneTurnWhite() 
    {
        foreach (ICommands command in _commandBuffer)
        {
            var cubes = GameObject.FindGameObjectsWithTag("Cube");
            foreach (var cube in cubes)
            {
                cube.GetComponent<MeshRenderer>().material.color = Color.white;
            }
        }
    }

    public void ResetCommands()
    {
        _commandBuffer.Clear();

    }

    // create a method to 'add' commands to the commandBuffer

    // create a play routine triggered by a play method to play back all the commmands
    // 1 second delay

    // create a rewind routine triggered by a rewind method to play in reverse, with 1 second delay

    // done = finished with changing colours, turn them all white

    // reset method clears the command buffer


}
