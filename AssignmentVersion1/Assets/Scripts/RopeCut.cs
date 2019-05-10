using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeCut : MonoBehaviour { 

    public Component hinge;



    private void Start()
    {
        hinge = GetComponent<HingeJoint>();
    }



    // Use this for initialization
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(hinge);
    }

}