using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClick : MonoBehaviour
{
    int damageAmount;
    bool isDead = false;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(rayOrigin, out hitInfo))
            {
                IDamagable<int> obj = hitInfo.collider.GetComponent<IDamagable<int>>();
                if (obj != null)
                {
                    Player player = hitInfo.collider.GetComponent<Player>();
                    if(player == null || player.IsDead() == false) // if its not an IDamagable, or if its a destroyed enemy,  or if the player is NOT dead
                    {
                        damageAmount = Random.Range(4, 40);
                        obj.Damage(damageAmount);
                    }
                }
            }
        }
    }
}
