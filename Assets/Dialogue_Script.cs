using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue_Script : MonoBehaviour
{
    // When player approaches NPC
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            Debug.Log("Press E to talk");
        }
    }

}
