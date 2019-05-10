using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class readytofire : MonoBehaviour {


    public bool fire = false;


    public void OnTriggerEnter(Collider other)
    {

        fire = true;
            
    }
}
