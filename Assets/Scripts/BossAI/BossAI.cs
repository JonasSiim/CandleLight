using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI : MonoBehaviour
{
    public float speed;

    public Transform target;
    public float chaseRange;

    public float attackRange;
    private float lastattackTime;
    public float attackDelay;

    public GameObject projectile;
    public float bulletForce; // do not set above 10!

    public Transform raycastPoint;
    public float distanceToPlayer;
 
   void Update()
    {

        Vector3 targetDirection = target.position - transform.position;



         distanceToPlayer = Vector3.Distance(transform.position, target.position);
        if (distanceToPlayer < attackRange) {
        //  Vector3 targetDirection = target.position - transform.position;
        //   float angle = Mathf.Atan2(targetDirection.x, targetDirection.y) * Mathf.Rad2Deg - 90f;
         //   Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
         //  transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 0 * Time.deltaTime);

            if (Time.time > lastattackTime + attackDelay) {
                RaycastHit2D hit = Physics2D.Raycast(raycastPoint.position, targetDirection, attackRange);
            
              if (hit.transform == target) {
                    GameObject newBullet = Instantiate(projectile, targetDirection, transform.rotation);
                    newBullet.GetComponent<Rigidbody2D>().AddRelativeForce(target.position*bulletForce, 0f);
                    lastattackTime = Time.time;
        //

                  }
             }
       }
    }
}
