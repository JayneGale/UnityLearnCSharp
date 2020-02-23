using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamagable<int>, Shoot
{
    private int _health;
    public int Health { get => _health; set => _health=60; }

    void Start()
    {
        _health = 40;
        print("On Start, Enemy " + this.name + "'s health is " + _health);
    }

    public void Damage(int damageAmount)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
        _health -= (int)damageAmount;
        print("Enemy " + this.name + "'s health is " + _health);
        if (IsDead())
        {
            _health = 0;
            print("Enemy " + this.name + " has died.");
            Destroy(this.gameObject);

        }
    }

public bool IsDead()
    {
        return _health < 1;
    }

    public void Shoot()
    {
        throw new System.NotImplementedException();
    }
}
