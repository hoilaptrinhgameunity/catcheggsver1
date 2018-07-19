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
	public Text gLevel;
	void Start () {
		GameObject.Find("GameManager").GetComponent<GameMNG>().SetGameState(0);
		gMoneyText.text = PlayerPrefs.GetInt ("Money").ToString();
		gTotalEggsCatchText.text =  PlayerPrefs.GetInt ("TotalEgg").ToString();
		gTotalEggsFailedText.text = PlayerPrefs.GetInt ("TotalEggFailed").ToString();
		gAgeText.text="Age:"+PlayerPrefs.GetInt ("Age").ToString();
		gNameText.text ="Name:"+PlayerPrefs.GetString ("Name");
		gLevel.text="Level:"+GameObject.Find("GameManager").GetComponent<GameMNG>().GetRankingLevel();
	}
	
	// Update is called once per frame
	void Update () {
		gLevel.text="Level:"+GameObject.Find("GameManager").GetComponent<GameMNG>().GetRankingLevel();
	}
	public void CloseArch()
	{
		transform.gameObject.active = false;
		GameObject.Find("GameManager").GetComponent<GameMNG>().SetGameState(1);
	}
}
