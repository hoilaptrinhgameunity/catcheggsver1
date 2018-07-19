using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Bucket : MonoBehaviour {

	Image healthBar; 
	[SerializeField]
	private Text HealthText;
	void Start(){
		healthBar = GetComponent<Image> ();
	}

	void Update () {
		healthBar.fillAmount = GameMNG.health / GameMNG.maxHealth;
		//string[] tmp = HealthText.text.Split (':');
		//HealthText.text =//tmp [0] + ": " + GameMNG.health + "/" + GameMNG.maxHealth;
		HealthText.text = GameMNG.health + "/" + GameMNG.maxHealth;
	}
}
