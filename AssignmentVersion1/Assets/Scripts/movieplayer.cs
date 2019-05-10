using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class movieplayer : MonoBehaviour
{
    public PlayableDirector PlayableDirector;

    public void OnTriggerEnter(Collider other)
    {
        PlayableDirector.Play();
        Destroy(this);
    }
    
   
    


}

