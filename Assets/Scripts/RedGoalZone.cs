using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedGoalZone : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        print("Red zone!");
        
        if(other.gameObject.layer == 6) // if other game object is a red ball
        {
            print("Point for Red!");

            UIManager.Instance.redScore ++;

            Destroy(other.gameObject);

            GameManager.Instance.redBallActive = false;

            // now update UI
            UIManager.Instance.ChangeRedScore();
        }

        if(other.gameObject.layer == 8) // if other game object is 8 ball
        {
            print("8 POINTS FOR BLUE!");

            UIManager.Instance.blueScore += 8;

            Destroy(other.gameObject);

            GameManager.Instance.eightBallActive = false;

            // now update UI
            UIManager.Instance.ChangeBlueScore();
        }
    }
}
