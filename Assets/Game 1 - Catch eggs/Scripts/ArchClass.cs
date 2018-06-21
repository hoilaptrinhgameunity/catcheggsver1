using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ArchClass : MonoBehaviour {

	// Use this for initialization
	public Text gMoneyText;
	public Text gTotalEggsCatchText;
	public Text gTotalEggsFailedText;
	public Text gAgeText;
	public Text gNameText;

	void Start () {
		gMoneyText.text = "Money "+PlayerPrefs.GetInt ("Money").ToString();
		gTotalEggsCatchText.text = "Success  "+ PlayerPrefs.GetInt ("TotalEgg").ToString();
		gTotalEggsFailedText.text = "Failed "+ PlayerPrefs.GetInt ("TotalEggFailed").ToString();
		gAgeText.text="Age "+ PlayerPrefs.GetInt ("Age").ToString();
		gNameText.text ="Name "+ PlayerPrefs.GetString ("Name");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void CloseArch()
	{
		transform.gameObject.active = false;
	}
}
