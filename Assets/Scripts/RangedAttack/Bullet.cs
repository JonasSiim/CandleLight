using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 40;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        RatRemoveLife rat = hitInfo.GetComponent<RatRemoveLife>();
        if (rat != null) {
            rat.TakeDamage(damage);
            Destroy(gameObject);
        }
          
        Debug.Log(hitInfo.name);


    }
}
