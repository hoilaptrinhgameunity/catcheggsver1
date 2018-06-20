using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class TouchControl : MonoBehaviour
{
	public GameObject gPanelShop;
	public GameObject gPanelPause;
	public GameObject gPanelArch;
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
	public void SetGameState(int aState)
	{
		if(aState==0)
		{
			Debug.Log("Pause Game");
			gPanelPause.active = true;
			//show panel 
		}
		else
		{
			Debug.Log("Resume Game");
			//hide panel pause
			gPanelPause.active = false;
		}
		GameObject.Find("GameManager").GetComponent<GameMNG>().SetGameState(aState);

	}
	public void OpenShop(bool aState)
	{
		Debug.Log("Open Shop");
		if(aState)
			GameObject.Find("GameManager").GetComponent<GameMNG>().SetGameState(0);
		else
			GameObject.Find("GameManager").GetComponent<GameMNG>().SetGameState(1);
		gPanelShop.active = aState;

	}
	public void OpenArch(){
		gPanelArch.active = true;
	}

}
