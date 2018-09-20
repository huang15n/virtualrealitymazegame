using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunScript : MonoBehaviour {
	public float range = 100f;
	public float damage = 100f;
	public int currentBullet = 0;
	public int maxBullet = 100;
	public Text bulletIndicator;


	public GameObject gunfireEffect;
	public GameObject bulletHoleEffect;
	// Use this for initialization
	void Start () {
		currentBullet = maxBullet;
		
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetButtonDown ("Fire1") && currentBullet > 0) {
			currentBullet--;
			Shoot ();

		}

		bulletIndicator.text = currentBullet + "/" + maxBullet;




		
	}

	public int getBullet(){
		return currentBullet;

	}

	public void addBullet(int bullet){
		currentBullet += bullet;

	}


	void Shoot(){
		RaycastHit hit;

		if (Physics.Raycast (transform.position, transform.forward, out hit, range)) {
			GameObject gunParticle = Instantiate (gunfireEffect, hit.point, Quaternion.FromToRotation (Vector3.up,hit.normal));
			GameObject bulletHole = Instantiate (bulletHoleEffect, hit.point, Quaternion.FromToRotation (Vector3.up,hit.normal));


			if (hit.transform.tag == "Zombie") {
				EnemyHealth enemyHealth = hit.transform.GetComponent<EnemyHealth> ();
				enemyHealth.damage (damage);

			}
			 
			Destroy (gunParticle,1f);
			Destroy (bulletHole,2f);

		}


	}
}
