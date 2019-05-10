using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumTImer : MonoBehaviour 
{
	public float waitInseconds = 1.0f;
	public float startTime;
	private bool started = false;
	void Start () 
	{
	}

	void Update () 
	{
		if (started) 
		{
			if (Time.time > startTime + waitInseconds) 
			{
				gameObject.AddComponent <Pendulum> ();
				Destroy (this);		
			}
		}
	}

	public void Activate()
	{
		started = true;
		startTime = Time.time;		
	}
}