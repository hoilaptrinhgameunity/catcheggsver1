using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CShop : MonoBehaviour {
	public Text gMoney;
	// Use this for initialization
	void Start () {
		gMoney.text=PlayerPrefs.GetInt("Money").ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void BuyNewBucket(int aType){
	//check money Hong Quan Le Fix
		/*if (aType > 2) {

			Debug.Log("Bucket Buying failed Not enought money"+aType);
		}*/
	//assume that we had enought money to take the new bucket'
		if (aType > 2) {
		
			Debug.Log("Bucket Buying failed "+aType);
		}

		GameObject.Find("BucketOBJ").GetComponent<BucketManager>().ChangeBucketByType(aType);
		Debug.Log("New Bucket Has been Buy "+aType);
	}

}
