using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveLife : MonoBehaviour
{

    public int Rathealth = 100;
    public void TakeDamage(int damage)
    {
        Rathealth -= damage;
        Debug.Log(Rathealth);

        if (Rathealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    public void Update()
    {
        //  Debug.Log("health is " + Rathealth);
    }

    //If the player touches the rat, he gets -1 life point


}