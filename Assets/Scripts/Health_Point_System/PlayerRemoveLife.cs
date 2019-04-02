using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRemoveLife : MonoBehaviour
{
 public  void OnTriggerEnter2D(Collider2D collision)
    {
        GameControlScript.health -= 1;
    }
}
