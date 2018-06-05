using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CNewGame : MonoBehaviour {

	public InputField playerName;
	public InputField playerAge;
	// Use this for initialization
	void Start () {
		Debug.Log("New Game Panel's Actived!");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OK_BTN()
	{
		PlayerPrefs.SetString("Name", playerName.text);
		PlayerPrefs.SetString("Age", playerAge.text);
		Debug.Log(playerName.text+" "+ playerAge.text+" Years Old Start New Game!");
	}
	void Close_BTN()
	{
		Debug.Log("New Game Close Panel!");
		gameObject.active = false;

	}
}
