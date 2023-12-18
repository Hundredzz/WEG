using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Collision : MonoBehaviour
{
    // Rigidbody + Collider 

    void OnCollisionEnter(Collision other) //Parameter
    {  
        if(other.gameObject.tag == "E") 
        {  
            Debug.Log("กระแท๊กเข้าไป"); 
            Destroy(other.gameObject); 
        }  
    } 

    void OnCollisionExit(Collision ss)
    {
        if(ss.gameObject.tag == "x") 
        {
        Debug.Log("ถอยออกแล้ว");     
        }
    }

    void OnCollisionStay(Collision ee)
    {
        if(ee.gameObject.tag == "s") 
        {
        Debug.Log("อยู่ด้านใน");     
        }
        
    }
    
}

