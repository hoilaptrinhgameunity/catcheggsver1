using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GuiManager : MonoBehaviour {
	//update by minh 7/6/2018
	public Text gMoney;
	//update 6/2/2018
	public GameObject NewGamePanel;
	//update by minh 3/11/2018
	public GameObject TouchPanel;

	public GameObject MainPanel;
	public GameObject HelpPanel;
	public GameObject InfoPanel;
	public GameObject CloserPanel;
	public GameObject ChangeBucket;
	public GameObject SpawnObject;
	public GameObject SettingPN;


	public Text DiemCaoNhat;
	public Text DiemHienTai;
	public Text DiemLucThua;
	public Text Cap;

	public Toggle toggleNhacNen;
	public Toggle toggleNhacGame;
	public AudioMixer audioMixer;

	private int maxHealth_Bucket = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int scoreint = GameObject.Find ("GameManager").GetComponent<GameMNG> ().theScore;
		DiemHienTai.text = scoreint.ToString();
		int cap = GameObject.Find ("GameManager").GetComponent<GameMNG> ().cap;
		Cap.text = cap.ToString ();
		gMoney.text = (GameObject.Find ("GameManager").GetComponent<GameMNG> ().GetMoney ()).ToString ();
		if (GameMNG.health == 0 && GameMNG.trangthai == 1) {
			GameMNG.trangthai = 0;
			if (scoreint < PlayerPrefs.GetInt ("DiemCaoNhat")) {
				DiemLucThua.text = "Điểm cao nhất: " + PlayerPrefs.GetInt ("DiemCaoNhat") + "\n" + "\n" + "Điểm của bạn là: " + scoreint.ToString ();
			} else if (scoreint > PlayerPrefs.GetInt ("DiemCaoNhat")) {
				DiemLucThua.text = "Chúc mừng đạt kỹ lục mới" + "\n" + "\n" + "Điểm cao nhất: " + scoreint.ToString ();
			}
			SpawnObject.active = false;
			InfoPanel.active = false;
			CloserPanel.active = true;
			GameMNG.health++;
			//ChangeBucket.active = false;
			//update by minh
			TouchPanel.active = false;
			if ( scoreint > PlayerPrefs.GetInt("DiemCaoNhat"))
				PlayerPrefs.SetInt("DiemCaoNhat", scoreint);
			
		}
		if (Input.GetKeyDown (KeyCode.F1)) {
			GameMNG.trangthai = 0;
		} else if (Input.GetKeyDown (KeyCode.F2)) {
			GameMNG.trangthai = 1;
		}
	}
	void StartGame()
	{
		Debug.Log("Start Button Clicked!");
		//update by minh
		gMoney.text=PlayerPrefs.GetInt("Money").ToString();
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
	void Help_BT()
	{
		Debug.Log("Help Button Clicked!");
		//update by minh
		TouchPanel.active = false;
		MainPanel.active = false;
		HelpPanel.active = true;
	}
	void HelpPanel_XacNhan()
	{
		Debug.Log("XacNhan Button Clicked!");
		//update by minh
		TouchPanel.active = false;
		HelpPanel.active = false;
		MainPanel.active = true;
		InfoPanel.active = false;
	}
	void CloserPannel_XacNhan()
	{
		Debug.Log("CloserPannel Button Clicked!");
		//update by minh
		TouchPanel.active = false;
		HelpPanel.active = false;
		InfoPanel.active = false;
		CloserPanel.active = false;

		MainPanel.active = true;
		GameObject.Find ("GameManager").GetComponent<GameMNG> ().SaveAllInfor ();
	}
	void ShopBT()
	{
		SceneManager.LoadScene ("Shop");
	}
	void BTThoat()
	{
		Application.Quit ();
	}
	void GamePause()
	{
		GameMNG.trangthai = 0;
	}
	void GameResume()
	{
		GameMNG.trangthai = 1;
	}

	void SettingBT()
	{
		SettingPN.active = true;
	}
	void SettingOKBT()
	{
		SettingPN.active = false;
	}
	public void OnPointerDown()
	{
		Debug.Log("Button was Down");		
	}

	public void setVolumeNhacNen(float volume){
		audioMixer.SetFloat ("NhacNen", volume);
		toggleNhacNen.isOn = false;
	}
	public void setVolumeNhacGame(float volume){
		audioMixer.SetFloat ("NhacGame", volume);
		toggleNhacGame.isOn = false;
	}
	public void NewGame()
	{
		Debug.Log("New game button ");
		NewGamePanel.active = true;
	}
}
