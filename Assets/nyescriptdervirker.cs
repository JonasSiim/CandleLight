using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using System.IO.Ports;

public class nyescriptdervirker : MonoBehaviour {

    public float speed;
    private float amountToMove;

    SerialPort sp = new SerialPort("/dev/cu.wchusbserial1410", 9600);

    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;
    }

    void Update()
    {
        amountToMove = speed * Time.deltaTime;

        if (sp.IsOpen)
        {
            try
            {
                MoveObject(sp.ReadByte());
                if (sp.ReadByte() != 0)
                {
                    print(sp.ReadByte());
                }
            }

            catch (System.Exception e)
            {
                print(e);
                throw;
            }
        }
    }

    void MoveObject(int direction)
    {
        if (direction == 1)
        {
            transform.Rotate(-20, 0, 0, Space.World);
        }

        if (direction == 2)
        {
            transform.Rotate(20, 0, 0 , Space.World);
        }
        if (direction == 3)
        {
            transform.Rotate(0, 20, 0, Space.World);
        }
        if (direction == 4)
        {
            transform.Rotate(0, -20, 0, Space.World);
        }
    }
}