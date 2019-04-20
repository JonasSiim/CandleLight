using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag  ("Player")) {
            GameControlScript.health -= 1;

            Destroy(gameObject);
        }

    }
}
