using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMNG : MonoBehaviour {
	//private member update by minh 2018
	private int _iMoney=0;
	private int _iTotalEggsCatch=0;//all eggs droped into bucket
	private int _iTotalEggsFailed = 0;//every eggs drop but had not been caught
	private string _sName="";
	private int _iAge = 0;

	public int theScore = 0;
	public int cap = 1;
	public static int expNextLeVel;
	public int expHienTai;
	public static int trangthai=0; //0 = pause 1= resume
	public static float maxHealth;
	public static float health;

	public void GiveMoneyForEgg(){
		int temp = Random.Range (1, 5);
			_iMoney+=temp;
	}
	public void IncreaEggResult(int iEggState){
		switch(iEggState){
		case 0://failed
			_iTotalEggsFailed++;
			break;
		case 2://failed
			_iTotalEggsCatch++;
			break;
		}
	}
	public void SaveAllInfor(){
		PlayerPrefs.SetInt ("TotalEgg",_iTotalEggsCatch);
		PlayerPrefs.SetInt ("TotalEggFailed",_iTotalEggsFailed);
		PlayerPrefs.SetInt ("Age",_iAge);
		PlayerPrefs.SetString ("Name",_sName);
	}
	void Start(){
		health = maxHealth;
		_iMoney = PlayerPrefs.GetInt ("Money");
		_iTotalEggsCatch = PlayerPrefs.GetInt ("TotalEgg");
		_iTotalEggsFailed = PlayerPrefs.GetInt ("TotalEggFailed");
		_iAge=PlayerPrefs.GetInt ("Age");
		_sName = PlayerPrefs.GetString ("Name");
	}
	void Update () {
		if (expHienTai >= expNextLeVel) {
			expHienTai = 0;
			expNextLeVel = expNextLeVel + cap;
			cap++;
			maxHealth++;
			health = maxHealth;

			if (SpawnerScript.spawnRate >= 0.9){
				SpawnerScript.spawnRate -= 0.3f;
		} else {
				SpawnerScript.spawnRate -= 0.15f;
		}
		}		
	}
	public void SetGameState(int aState)
	{
		trangthai = aState;
	}
	/*void OnGUI() {
		GUI.Label(new Rect(10, 10, 100, 20), theScore.ToString());
	}*/
}
