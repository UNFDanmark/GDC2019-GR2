﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3 : MonoBehaviour
{
    Rigidbody rb;
    public float rotationSpeed = 50f;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Makes the player go forward constantly
        rb.velocity = transform.up * Time.deltaTime * speed;

        //Controls rotation on the player
        if (Input.GetKey("l"))
        {
            transform.Rotate(0, 0, Time.deltaTime * rotationSpeed, Space.Self);
        }



        if (Input.GetKey("ø"))
        {
            transform.Rotate(0, 0, Time.deltaTime * -rotationSpeed, Space.Self);
        }
    }

}

