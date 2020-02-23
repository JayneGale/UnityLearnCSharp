using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other == Player.Instance.gameObject.GetComponent<Collider>())
        {
            UIManager.Instance.UpdateScore(20);
            Destroy(this.gameObject);
        }
    }
}
