﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRemoveLife : MonoBehaviour
{
 public  void OnTriggerEnter2D(Collider2D collision)
   {
        if (collision.gameObject.tag == "Player")
        {
            GameControlScript.health -= 1;
        }
       
    }
}
