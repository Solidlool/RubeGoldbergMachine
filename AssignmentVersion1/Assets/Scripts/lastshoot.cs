using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastshoot : MonoBehaviour {

    public GameObject bullet;
    public float speed = 100f;


	public readytofire RF;
    
	public AudioClip SoundToPlay;

	private AudioSource audioSource;

	bool timerCheck = false;
	float timer = 0.0f;
	public float TimeToFire = 2.0f;

	void Awake()
    {
		audioSource = GetComponent<AudioSource> ();
    }
		
    void Update()
    {
		if (RF.fire)
        {
			if (timerCheck == false) 
			{
				timer += Time.deltaTime;
				if (timer >= TimeToFire) 
				{
					timerCheck = true;
					Debug.Log ("Timer met");
				}
			} 
			else 
			{
				Debug.Log ("Fire");
				GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
				Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
				instBulletRigidbody.AddForce(Vector3.back * speed);

				audioSource.PlayOneShot (SoundToPlay);

				Destroy (this);
			}
        }
    }
}
