using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using UnityEngine;

public class ClickCommand : ICommands
{
    private GameObject _cube;
    private Color _colour;
    private Color _previousColour;

    public ClickCommand(GameObject cube, Color colour)
    {
        this._cube = cube;
        this._colour = colour;

    }
    public void Execute()
    {
        _previousColour = _cube.GetComponent<MeshRenderer>().material.color;
        _cube.GetComponent<MeshRenderer>().material.color = _colour;
    }

    public void Undo ()
    {
        _cube.GetComponent<MeshRenderer>().material.color = _previousColour;
    }
}
