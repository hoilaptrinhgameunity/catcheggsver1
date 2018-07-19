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
		/**fix by hong quan le**/
		int number;
		if (playerName.text.Length < 4) {
			Debug.Log ("condition: length name minimun equals 4");
			return;
		}
		if(!int.TryParse(playerAge.text, out number)){
			Debug.Log("condition: Age is number");
			return;
		}
		if (playerName.text.Length >= 4 && int.TryParse (playerAge.text, out number)) {
			PlayerPrefs.SetString ("Name", playerName.text);
			int iAge = System.Convert.ToInt32 (playerAge.text);
			PlayerPrefs.SetInt("Age",iAge);
			Debug.Log (playerName.text + " " + iAge + " Years Old Start New Game!");
			gameObject.active = false;

		}

	}
	void Close_BTN()
	{
		Debug.Log("New Game Close Panel!");
		gameObject.active = false;

	}
}
