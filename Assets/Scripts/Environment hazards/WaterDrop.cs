using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  
public class WaterDrop : MonoBehaviour
{
    Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = gameObject.transform.position;
        Debug.Log(startPosition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void OnCollisionEnter2D (Collision2D col)
    {

        Instantiate(gameObject, startPosition, Quaternion.identity);

        if (col.gameObject.name == "Player")
        {
            GameControlScript.health -= 1;
        }

        Destroy(gameObject);
    }

}