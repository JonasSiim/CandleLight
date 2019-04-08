﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;


public class PlayerController : MonoBehaviour
{

    wrmhl myDevice = new wrmhl();

    public string portName = "/dev/cu.wchusbserial1410";
    public int baudRate = 9600;
    public int ReadTimeout = 20;
    public int QueueLength = 1;

    public float speed = 1;
    public float quantifier = 1;
    private Rigidbody rb;

    void Start()
    {
        myDevice.set(portName, baudRate, ReadTimeout, QueueLength);
        myDevice.connect();
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        string inputstring = myDevice.readQueue();
        string[] variables = inputstring.Split(',');
        int up, down, left, right;

        Int32.TryParse(variables[0], out up);
        Int32.TryParse(variables[1], out down);
        Int32.TryParse(variables[2], out left);
        Int32.TryParse(variables[3], out right);

        float moveHorizontal = quantifier * ((right * 0.01f) + (left * 0.01f * -1f));

        float moveVertical = quantifier * ((down * 0.01f * -1f) + (up * 0.01f));

        print(moveVertical);

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }
    void OnApplicationQuit()
    {
        myDevice.close();
    }
}