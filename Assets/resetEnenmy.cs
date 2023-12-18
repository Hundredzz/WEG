using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetEnenmy : MonoBehaviour
{
    public Vector3 resetPoint;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collision)
    {

        if (collision.tag == "Player")
        {
            transform.position = resetPoint;
        }
    }
}
