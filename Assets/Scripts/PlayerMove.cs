﻿using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //this is a refference to the rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    void FixedUpdate()
    {
        //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

    }
}