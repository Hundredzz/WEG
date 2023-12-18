using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class TimelineController : MonoBehaviour
{
    private PlayableDirector Timeline1;
    public GameObject OB;

    void Start()
    {
        Timeline1 = OB.GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Timeline1.Play();
        }
    }
}
