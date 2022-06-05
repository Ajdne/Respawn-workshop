using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayerMovement : MonoBehaviour
{
    private int speed;

    private void Start()
    {
        speed = GameManager.Instance.moveSpeed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float inputX = Input.GetAxis("Horizontal Red");
        float inputZ = Input.GetAxis("Vertical Red");

        transform.Translate(new Vector3 (speed * inputX * Time.deltaTime, 0, speed * inputZ * Time.deltaTime));
    }
}
