using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAll : MonoBehaviour
{
    //Collider only
    void OnTriggerEnter(Collider other)
    {
        /*switch (other.gameObject.tag)
        {
            case "ชื่อ tag":
                //Do
            break;

            case "ชื่อ tag":
                //Do
            break;
        }*/
    }

    void OnTriggerExit(Collider other)
    {

    }

    void OnTriggerStay(Collider other)
    {

    }
}
