using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlayerMovement : MonoBehaviour
{

    private int speed;

    private void Start()
    {
        speed = GameManager.Instance.moveSpeed;
    }
    
    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal Blue");
        float inputZ = Input.GetAxis("Vertical Blue");

        transform.Translate(new Vector3 (speed * inputX * Time.deltaTime, 0, speed * inputZ * Time.deltaTime));
    }
}
