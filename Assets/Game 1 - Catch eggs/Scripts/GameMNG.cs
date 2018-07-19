using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMNG : MonoBehaviour {
	private int _iExp=0;
	private int _iRankLevel=1;
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
	public int GetMoney(){
		return _iMoney;
	}
	public int CaculatingExpPercent (){
		float result=((float)_iExp / ((float)(_iRankLevel*(10+_iRankLevel) + 1)))*100;
		return (int)result;
	}
	public void GiveMoneyForEgg(){
		int temp = Random.Range (1, 5);
			_iMoney+=temp;
	}
	public int GetRankingLevel (){
		return _iRankLevel;
	}
	public void IncreaEggResult(int iEggState){
		switch(iEggState){
		case 0://failed
			_iTotalEggsFailed++;
			break;
		case 1://Success
			_iTotalEggsCatch++;

			int tExp = _iExp + Random.Range (1,3);
			Debug.Log ("Exp: " + tExp + "/" + (_iRankLevel*(10+_iRankLevel) + 1));
			if (tExp > (_iRankLevel*(10+_iRankLevel) + 1))
				_iRankLevel++;
			else
				_iExp = tExp;
			// give money 
			_iMoney += Random.Range (1,10);

			break;
		}
	}
	public void SaveAllInfor(){
		PlayerPrefs.SetInt ("TotalEgg",_iTotalEggsCatch);
		PlayerPrefs.SetInt ("TotalEggFailed",_iTotalEggsFailed);
		PlayerPrefs.SetInt ("Age",_iAge);
		PlayerPrefs.SetString ("Name",_sName);
		PlayerPrefs.SetInt ("Exp",_iExp);
		PlayerPrefs.SetInt ("RankLevel",_iRankLevel);
		PlayerPrefs.SetInt ("Money",_iMoney);
	}
	void Start(){
		health = maxHealth;
		_iMoney = PlayerPrefs.GetInt ("Money");
		_iTotalEggsCatch = PlayerPrefs.GetInt ("TotalEgg");
		_iTotalEggsFailed = PlayerPrefs.GetInt ("TotalEggFailed");
		_iAge=PlayerPrefs.GetInt ("Age");
		Debug.Log ("Age:" + _iAge);
		_sName = PlayerPrefs.GetString ("Name");
		//update 7/12/2018
		_iExp=PlayerPrefs.GetInt ("Exp");
		_iRankLevel=PlayerPrefs.GetInt ("RankLevel");

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
