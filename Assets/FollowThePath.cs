using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowThePath : MonoBehaviour
{
    public Transform[] patrollingPoints;
    public float[] patrolRotation;
    public Transform target;
    public float patrolSpeed;
    public float rotation;

    public int currentPoint;

    // Use this for initialization
    void Start()
    {
        transform.position = patrollingPoints[0].transform.position;
        currentPoint = 0;
        target = patrollingPoints[currentPoint + 1];
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPoint >= patrollingPoints.Length-1)
        {
            currentPoint = 0;
        }

        if (transform.position == patrollingPoints[currentPoint].position)
        {
            currentPoint++;

        }

        transform.position = Vector3.MoveTowards(transform.position, patrollingPoints[currentPoint].position, patrolSpeed * Time.deltaTime);
    }
}
