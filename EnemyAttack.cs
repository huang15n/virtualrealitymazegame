using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

	public float damage = 20f;
	
	// Update is called once per frame
	void Update () {
		
	}



	void OnTriggerEnter(Collider player){
		 
		if (player.tag == "Player") {
			PlayerHeathController health = player.GetComponent<PlayerHeathController> (); 
			health.damage (damage);

		}


	}


	void OnTriggerStay(Collider player){

		if (player.tag == "Player") {
			PlayerHeathController health = player.GetComponent<PlayerHeathController> (); 
			health.damage (damage);

		}


	}


}
