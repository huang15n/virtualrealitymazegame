using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioSourceController : MonoBehaviour {
	public AudioClip []clips;
	private AudioSource playerAS;
	// Use this for initialization
	void Start () {
		playerAS = GetComponent<AudioSource> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}


	void walk(){

		playerAS.PlayOneShot (clips[0]);
	}

	void run(){

		playerAS.PlayOneShot (clips[1]);
	}

	void fire(){
		playerAS.PlayOneShot (clips[2]);

	}
}
