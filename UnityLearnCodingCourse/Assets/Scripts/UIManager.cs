using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static int totalScore = 0;
    private float bill = 40f;
    public float tipPercent = 0.20f;
    bool isBoss = false;

    private static UIManager _instance; //p[rivate variable to declare the isntance of this class - has to be static
    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject("UI_Manager");
                go.AddComponent<UIManager>();
                //Debug.LogError("UIManager is NULL");
            }
            return _instance;
        }
    }
    private void Awake()
    {
        _instance = this;        
    }

    public void UpdateScore(int score)
    {
        totalScore += score;
        print("Score: " + totalScore);
        if (isBoss == false && totalScore > 50)
        {
            isBoss = true;
            print("You're the boss!");
            Player.Instance.GetComponent<Renderer>().material.color = Color.yellow;
        }
        print("Notifying the GameManager");
        GameManager.Instance.DisplayName();
    }

    public void TotalBill(float tipPercent)
    {
        float tip = bill * tipPercent;
        float totalAmount = bill + tip;
        print("Bill is:" + bill + " and tip is:" + tip + " so total owed is:" + totalAmount);
    }

}
