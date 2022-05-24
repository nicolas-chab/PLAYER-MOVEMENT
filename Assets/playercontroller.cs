﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
          {
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(rotationSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-rotationSpeed, 0, 0);
        }
       
    }
}
