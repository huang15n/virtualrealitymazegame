using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {
	public float currentHealth = 0;
	public float maxHealth = 100;

	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {


		
	}


	public void damage(float damage){

		if (currentHealth > 0) {
			currentHealth -= damage;

		}
		if(currentHealth <= 0){
			death ();
		}
	}


	void death(){
		
			Destroy (gameObject);

	 

	}


}
