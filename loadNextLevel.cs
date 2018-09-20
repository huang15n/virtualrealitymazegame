using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadNextLevel : MonoBehaviour {
	public string levelname;
	void OnTriggerEnter(Collider player){
		if (player.tag == "Player") {
			SceneManager.LoadScene (levelname);

		}

	}

 
	 
}
