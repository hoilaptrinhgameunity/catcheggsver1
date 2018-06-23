using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CNewGame : MonoBehaviour {

	public GameObject TouchPanel;
	public GameObject MainPanel;
	public GameObject SpawnObject;
	public GameObject InfoPanel;
	public Text DiemCaoNhat;
	private int maxHealth_Bucket = 2;

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
		int number;
		if (playerName.text.Length < 4) {
			Debug.Log ("condition: length name minimun equals 4");
		}
		if(!int.TryParse(playerAge.text, out number)){
			Debug.Log("condition: Age is number");
		}
		if (playerName.text.Length >= 4 && int.TryParse (playerAge.text, out number)) {
			PlayerPrefs.SetString ("Name", playerName.text);
			PlayerPrefs.SetString ("Age", playerAge.text);
			Debug.Log (playerName.text + " " + playerAge.text + " Years Old Start New Game!");
			gameObject.active = false;
			StartGame ();
		}
	}
	void Close_BTN()
	{
		Debug.Log("New Game Close Panel!");
		gameObject.active = false;

	}

	void StartGame()
	{
		Debug.Log("Start Button Clicked!");
		//update by minh
		TouchPanel.active = true;

		MainPanel.active = false;
		SpawnObject.active = true;
		InfoPanel.active = true;
		//ChangeBucket.active = true;
		GameObject.Find ("GameManager").GetComponent<GameMNG> ().theScore = 0;
		GameMNG.health = maxHealth_Bucket;
		GameMNG.maxHealth = maxHealth_Bucket;
		GameObject.Find ("GameManager").GetComponent<GameMNG> ().cap = 1;
		SpawnerScript.spawnRate = 1.6f;
		GameMNG.expNextLeVel = 3;
		GameObject.Find ("GameManager").GetComponent<GameMNG> ().expHienTai = 0;
		DiemCaoNhat.text =  PlayerPrefs.GetInt("DiemCaoNhat").ToString();
		GameMNG.trangthai = 1;
		//		GameObject.Find ("BucketOBJ").GetComponent<BucketManager> ().CreateBucket();
	}
}
