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
    public float bulletForce;
 
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, target.position);
        if (distanceToPlayer < attackRange) {
            Vector3 targetDirection = target.position - transform.position;
            float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg - 90f;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 0 * Time.deltaTime);

            if (Time.time > lastattackTime + attackDelay) {
                RaycastHit2D hit = Physics2D.Raycast(transform.position, target.position, attackRange);
                if (hit.transform == target) {
                    GameObject newBullet = Instantiate(projectile, transform.position, transform.rotation);
                    newBullet.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2 (0f, bulletForce));
                    lastattackTime = Time.time;

                }
            }
        }
    }
}
