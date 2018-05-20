using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class TouchControl : MonoBehaviour
{

	// Use this for initialization
	int iKey = 0;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void setKeyArrowTouch(int aKey)
	{
		iKey= aKey;
	}
	public int getKeyArrowTouch()
	{
		int rKey = iKey;
		return rKey;

	}
	

}
