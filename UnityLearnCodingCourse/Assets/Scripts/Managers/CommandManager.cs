using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private List<ICommands> _commandBuffer = new List<ICommands>();

    private void Awake()
    {
        _instance = this;
    }

    // create a method to add commands to the bugger
    // create a play routing triggerted by a play method to play back alll the commmands
    //1 second delay
    //create a rewind routine triggered by a rewind method to play in reverse with 1 second delay

    //done = finished with changing colours, turn them all white
    // reset method clears the command buffer


}
