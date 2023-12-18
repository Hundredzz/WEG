using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddF : MonoBehaviour
{
    public GameObject ball;
    private Rigidbody rb;

    public float force = 500f;

    // Start is called before the first frame update
    void Start()
    {
        rb = ball.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        rb.AddForce(ball.transform.forward * force);
        rb.useGravity = true;
    }
}
