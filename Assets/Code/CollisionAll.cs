using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAll : MonoBehaviour
{
    //Rigidbody + Collider
    void OnCollisionEnter(Collision soso)
    {
        if(soso.gameObject.tag == "pin")
        {
            Destroy(this.gameObject);
        }
    }







    void OnCollisionExit(Collision other)
    {

    }

    void OnCollisionStay(Collision other)
    {

    }
}
