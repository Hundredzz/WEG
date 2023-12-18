using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class HitPlayTime : MonoBehaviour
{
    private PlayableDirector Timeline1;

    public GameObject OB;

    void Start()
    {
        Timeline1 = OB.GetComponent<PlayableDirector>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {

            Timeline1.Play();
            
            Destroy(this.gameObject);
        }
 
        
    }
}
