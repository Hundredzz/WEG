using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Trigger : MonoBehaviour
{
    //  Collider 

    void OnTriggerEnter(Collider other) //Parameter
    {  
        if(other.gameObject.tag == "E") 
        {  
            Debug.Log("เจอผี"); 
            //Destroy(other.gameObject); 
        }  
    } 

    void OnTriggerExit(Collider ss)
    {
        if(ss.gameObject.tag == "E") 
        {
        Debug.Log("หนีผี");     
        }
    }

    void OnTriggerStay(Collider ee)
    {
        if(ee.gameObject.tag == "E") 
        {
        Debug.Log("ผีเกาะหัว");     
        }
        
    }
    
}

