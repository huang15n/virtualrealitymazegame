using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMotion : MonoBehaviour {
	public Transform player;
	private NavMeshAgent agent;
	private Animator enemyAnimationController;
	// Use this for initialization
	void Start () {

		agent = GetComponent<NavMeshAgent> ();
		enemyAnimationController = GetComponent<Animator> ();// this is to set set the animator controller 

	
		
	}

	// Update is called once per frame
	void Update () {
		agent.SetDestination (player.position);
		Vector3 direction = (player.position - transform.position).normalized;
		Quaternion lookRotation = Quaternion.LookRotation(direction);
		transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 2);
		if (agent.transform.position.x - player.transform.position.x < 5  || agent.transform.position.z - player.transform.position.z < 5 ) {

			enemyAnimationController.SetBool ("walk", true);

		} else {
			enemyAnimationController.SetBool ("walk", false);

		}


		 

	}
}
