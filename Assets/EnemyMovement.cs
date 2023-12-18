using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float maxSpeed = 10f;
    public float minSpeed = 5f;
    public float detectionRadiusMax = 10f;
    public float detectionRadiusMin = 5f;
    public AudioSource sfx;
    public LayerMask obstacleLayer; // Define a layer for obstacles (e.g., walls)

    private Transform player;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        Vector3 moveDirection = (player.position - transform.position).normalized;

        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= detectionRadiusMin)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, moveDirection, out hit, detectionRadiusMin, obstacleLayer))
            {

                float speed = Mathf.Lerp(maxSpeed, minSpeed, hit.distance / detectionRadiusMax);
                transform.Translate(moveDirection * speed * Time.deltaTime);
            }
            else
            {
                float speed = Mathf.Lerp(maxSpeed, minSpeed, distanceToPlayer / detectionRadiusMax);
                transform.Translate(moveDirection * speed * Time.deltaTime);
            }

            if (!sfx.isPlaying)
            {
                sfx.Play();
            }
        }
        else if (distanceToPlayer <= detectionRadiusMax)
        {
            
            RaycastHit hit;
            if (Physics.Raycast(transform.position, moveDirection, out hit, detectionRadiusMin, obstacleLayer))
            {

                float speed = Mathf.Lerp(maxSpeed, minSpeed, hit.distance / detectionRadiusMax);
                transform.Translate(moveDirection * speed * Time.deltaTime);
            }
            else
            {
                float speed = Mathf.Lerp(maxSpeed, minSpeed, distanceToPlayer / detectionRadiusMax);
                transform.Translate(moveDirection * speed * Time.deltaTime);    
            }
            
        }
        
    }


}
