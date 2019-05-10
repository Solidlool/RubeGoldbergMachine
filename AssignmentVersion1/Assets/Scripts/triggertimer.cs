using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggertimer : MonoBehaviour 
{
	public Transform[] pends;

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag.Contains ("Balls")) 
		{
			for (int i = 0; i < pends.Length; i++) 
			{
				pends [i].GetComponent<PendulumTImer> ().Activate ();
			}
		}
	}
}
