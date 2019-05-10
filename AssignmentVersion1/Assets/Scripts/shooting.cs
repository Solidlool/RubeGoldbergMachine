using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {


    public GameObject bullet;
    public float speed = 100f;
    
    public GameObject fire;
	public AudioClip SoundToPlay;

	private AudioSource audioSource;
   

    
    
	void Awake()
	{
		audioSource = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.Space ))
        {

            GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
                Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            instBulletRigidbody.AddForce(Vector3.forward * speed);
			audioSource.PlayOneShot (SoundToPlay);
             
        }
	}
}
