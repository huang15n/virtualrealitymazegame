using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAudioSourceController : MonoBehaviour {
	public AudioClip []clips;
	private AudioSource enemyAS;
	// Use this for initialization
	void Start () {
		enemyAS = GetComponent<AudioSource> ();

	}

 
	
	void attack(){

		enemyAS.PlayOneShot (clips[0]);
	}



}
