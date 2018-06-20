using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CShop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void BuyNewBucket(int aType){
	//check money Hong Quan Le Fix
	//assume that we had enought money to take the new bucket'
		if (aType > 2) {
		
			Debug.Log("Bucket Buying failed "+aType);
		}

		GameObject.Find("BucketOBJ").GetComponent<BucketManager>().ChangeBucketByType(aType);
		Debug.Log("New Bucket Has been Buy "+aType);
	}

}
