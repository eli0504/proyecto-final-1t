using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private float verticalInput;
    private float horizontalInput;
    public float turnspeed = 5f;

    private void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * turnspeed * Time.deltaTime * verticalInput);   //VERTICAL MOVEMENT

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * turnspeed * Time.deltaTime * horizontalInput);  //HORIZONTAL MOVEMENT
    }
}
