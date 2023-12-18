using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineUIController : MonoBehaviour
{
    private PlayableDirector timeline1;
    public GameObject ob;

    // Start is called before the first frame update
    void Start()
    {
        timeline1 = ob.GetComponent<PlayableDirector>();
    }

    public void PlayTimeline1()
    {
        timeline1.Play();
    }
}
