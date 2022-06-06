using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        
        Destroy(other.gameObject);

        if(other.gameObject.layer == 9) // if other is the red player
        {
            GameManager.Instance.redAlive = false;
        }

        if(other.gameObject.layer == 10) // if other is the blue player
        {
            GameManager.Instance.blueAlive = false;
        }
    }
}
