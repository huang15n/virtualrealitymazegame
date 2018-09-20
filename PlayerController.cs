using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {



	public float playerSpeed = 0.1f;
	public float playerOriginalSpeed;
	public float playerRunSpeed = 10f;
	public float rotationSpeed = 10f;
	private Rigidbody playerRB;
	private Animator playerAnimator;
	 
	private float moveInX ;
	private float moveInZ;
    
	private float rotationInX;
 
	 


	void Start () {
		playerRB = GetComponent<Rigidbody> ();
		playerAnimator = GetComponent<Animator> ();
	 
		playerOriginalSpeed = playerSpeed;
		
	}
	
	// Update is called once per frame
	void Update () {

		moveInX = Input.GetAxisRaw ("Vertical") * playerSpeed ;
		moveInZ = Input.GetAxisRaw ("Horizontal") * playerSpeed;
		playerAnimator.SetFloat ("walk",Mathf.Abs(moveInX) +Mathf.Abs (moveInZ ));
		rotationInX = Input.GetAxisRaw ("Mouse X");
		 
		playerRB.transform.RotateAround (Vector3.up,rotationInX);
		 

		  
		transform.position += transform.forward * moveInX * playerSpeed ;
		transform.position += transform.forward * (-1) * moveInZ ;
		if (Input.GetKey (KeyCode.LeftShift)) {
			moveInX = Input.GetAxisRaw ("Vertical") * playerRunSpeed;
			moveInZ = Input.GetAxisRaw ("Horizontal")  * playerRunSpeed;
			 
			playerAnimator.SetFloat ("run",moveInX + moveInZ+5);

			transform.position += transform.forward * moveInX * playerRunSpeed ;

		} else {
			playerAnimator.SetFloat ("run",0);


		}



		 

		if (Input.GetButtonDown ("Fire1") ) {
			playerAnimator.SetBool ("fire", true);

		} else {
			playerAnimator.SetBool ("fire", false);

		}
	 
		
	}
}
