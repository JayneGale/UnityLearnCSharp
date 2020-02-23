using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoSingleton<Player>, IDamagable<int>
{
    private int _health;
    public int Health { get => _health; set => _health = 100; }
    public string name;
    public Color colour;
    public List<Color> colours;
    private bool isGamever;

    [SerializeField]
    private float _speed = 1f;

    public override void Init()

    {
        base.Init();
        Debug.Log("Player initialised");
        //transform.position = new Vector3(0, 0, 0);
    }

    public void Damage(int damageAmount)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
        _health -= damageAmount;
        print("Susan's health is " + _health);
        if (IsDead())
        {
            _health = 0;
            print("Player " + this.name + " has died.");
            //Destroy(this.gameObject);
        }
    }

    public bool IsDead()
    {
        return _health < 0;
    }

    void Start()
    {
        GameManager.Instance.DisplayName();
        SpawnManager.Instance.StartSpawning();
        LevelManager.Instance.LoadLevel();
        UIManager.Instance.TotalBill(UIManager.Instance.tipPercent);
        _health = 100;
        isGamever = false;

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UtilityHelper.ChangeColour(this.GetComponent<Renderer>(), colour, true);
            //UIManager.Instance.UpdateScore(10);
            CheckGameOver();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            UtilityHelper.RandomColour(this.GetComponent<Renderer>(), colours);
        }

        //switch (UIManager.totalScore)
        //{
        //    case 20: //score is 20
        //        print("Score is 20! " + UIManager.totalScore);
        //        break;
        //    case 40: //score is 40
        //        print("Score is 40! " + UIManager.totalScore);
        //        break;
        //    default:
        //            print("Score must be 20 or 40" + UIManager.totalScore);
        //            break;
        //}

        if (Input.GetKeyDown(KeyCode.P))
        {
            _speed += 1f;
            if (_speed > 5f) print("Slow down " + _speed);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            _speed -= 1f;
            if (_speed < -5f) print("Slow down " + _speed);
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput, 0, 0) * _speed * Time.deltaTime);
    }

    private void CheckGameOver()
    {
        isGamever = true;
        print("Game is over ");
    }
}
