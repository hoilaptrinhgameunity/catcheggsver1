using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketManager : MonoBehaviour {
	public GameObject eggPrefab;
	public GameObject eggPrefab1;
	public GameObject touchController;
	// Use this for initialization
	//UPDATE 10:32 6/13/2018 BY MINH
	//CREATE BUCKET create_bucket1();WITHIN ANYTYPE
	public GameObject[] eggPrefabs;
	void CreateBuketType(int aType){
		
	}
	void Start () {	
		create_bucket1();
		}
	
	// Update is called once per frame
	void Update () {
		runBucket ();
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			create_bucket1 ();
		}
		else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			create_bucket2();
		}
	}
	void create_bucket1(){
		eggPrefab1.SetActive (true);
		eggPrefab.SetActive (false);
	}
	void create_bucket2(){
		eggPrefab.SetActive (true);
		eggPrefab1.SetActive (false);
	}

	void activeBK1(){
		eggPrefab1.active = true;
		eggPrefab.active = false;
	}
	void activeBK2(){
		eggPrefab.active = true;
		eggPrefab1.active = false;
	}
	void runBucket(){
		//These two lines are all there is to the actual movement..
		float moveInput = 0;
		int iKey = touchController.GetComponent<TouchControl>().getKeyArrowTouch();
		if (iKey==0)
		moveInput= Input.GetAxis("Horizontal") * Time.deltaTime * 3; 
		else
		{
			if(iKey==1)
			{
				moveInput = -5 *Time.deltaTime;//Vector3.right * Time.deltaTime;
			}
			else if (iKey==2)
			{
				moveInput = 5* Time.deltaTime;//Vector3.left * Time.deltaTime;
			}

		}

		transform.position += new Vector3(moveInput, 0, 0);

		//Restrict movement between two values
		if (transform.position.x <= -2.5f || transform.position.x >= 2.5f)
		{
			float xPos = Mathf.Clamp(transform.position.x, -2.5f, 2.5f); //Clamp between min -2.5 and max 2.5
			transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
		}
	}

}
