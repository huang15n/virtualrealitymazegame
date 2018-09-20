using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHeathController : MonoBehaviour {
	public float currentHealth;
	public float maxHealth = 1000f;
	public Image healthIndicator;
	public Image bloodScreen;
	private float flashSpeed = 5.0f;
	private bool damaged = false;
	private Color bloodColor = new Color(255f,255f,255f,0.5f);
	private float filledAmount;
	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
		filledAmount = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (damaged) {
			bloodScreen.color = bloodColor;

		} else {
			bloodScreen.color = Color.Lerp (bloodScreen.color, Color.clear, flashSpeed * Time.deltaTime);
		}
		damaged = false;

		   
	}

	public void damage(float damageValue){
		damaged = true;
		if (currentHealth > 0) {
			currentHealth -= damageValue;
			 
			float amount = currentHealth / 100 / 360;
			filledAmount -= amount;
			healthIndicator.fillAmount = filledAmount; 

			 
		} else {
			 
			healthIndicator.fillAmount = 0f; 

		}


	}


	public void death(){
		bloodColor = new Color(255f,255f,255f,1f);
		bloodScreen.color = bloodColor;

	}


}
