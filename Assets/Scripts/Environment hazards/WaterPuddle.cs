using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPuddle : MonoBehaviour
{
    // Start is called before the first frame update
    private float nextDamage;
    float DamageDelay = 1.5f;

    void Start()
    {

        
        float time = Time.deltaTime;
        nextDamage = Time.time + DamageDelay;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (nextDamage <= Time.time)
        {
            nextDamage = Time.time + DamageDelay;
            GameControlScript.health -= 1;
        }
    }

}
