using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform target;
    public float speed;

    Rigidbody rbEnemy;
    
    // Start is called before the first frame update
    void Start()
    {
        rbEnemy = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        Vector3 move = Vector3.MoveTowards(transform.position , target.position , speed * Time.deltaTime);    

        rbEnemy.MovePosition(move);

        transform.LookAt(target);
    }
}
