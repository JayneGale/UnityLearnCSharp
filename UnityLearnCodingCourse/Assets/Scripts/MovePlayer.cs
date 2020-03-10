using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public KeyCode upKey = KeyCode.UpArrow;
    public KeyCode downKey = KeyCode.DownArrow;
    public KeyCode leftKey = KeyCode.LeftArrow;
    public KeyCode rightKey = KeyCode.RightArrow;
    ICommands moveUp, moveDown, moveLeft, moveRight;

    [SerializeField]
    private float _speed = 2.0f;

    void Update()
    {
        if (Input.GetKey(upKey))
        {
            moveUp = new MoveUpCommand(this.transform, _speed);
            moveUp.Execute();
            CommandManager.Instance.AddBuffer(moveUp);
        }
        else if (Input.GetKey(downKey))
        {
            moveDown = new MoveDownCommand(this.transform, _speed);
            moveDown.Execute();
            CommandManager.Instance.AddBuffer(moveDown);


        }
        else if (Input.GetKey(rightKey))
        {
            moveRight = new MoveRightCommand(this.transform, _speed);
            moveRight.Execute();
            CommandManager.Instance.AddBuffer(moveRight);


        }
        if (Input.GetKey(leftKey))
        {
            moveLeft = new MoveLeftCommand(this.transform, _speed);
            moveLeft.Execute();
            CommandManager.Instance.AddBuffer(moveLeft);
        }
    }
}
