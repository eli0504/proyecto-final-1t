using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private float verticalInput;
    private float horizontalInput;
    private float turnspeed = 5f;  //player speed

    private void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * turnspeed * Time.deltaTime * verticalInput);   //VERTICAL MOVEMENT

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * turnspeed * Time.deltaTime * horizontalInput);  //HORIZONTAL MOVEMENT
    }
}
