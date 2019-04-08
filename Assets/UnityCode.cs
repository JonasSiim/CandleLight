using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using System.IO.Ports;


public class UnityCode : MonoBehaviour

{
    SerialPort stream = new SerialPort("/dev/cu.usbmodem1411", 9600);
    int amountToMove = 0;
    public int speed = 0;

    void Start()
    {
        stream.Open();
        stream.ReadTimeout = 1;
    }

    // Update is called once per frame
    void Update()
    {
        amountToMove = (100);
        if (stream.IsOpen)
        {
            try
            {
                MoveCube(stream.ReadByte());
                Debug.Log(stream.ReadByte());

            }
            catch (System.Exception)
            {

            }
        }
    }


    void MoveCube(int dir)
    {
        if (dir == 1)
        {
            transform.Rotate(10, 0, 0, Space.Self);
        }
        if (dir == 2)
        {
            transform.Rotate(0, 10, 0, Space.Self);
        }



    }
}
