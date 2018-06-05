using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMNG : MonoBehaviour {
	
	public int theScore = 0;
	public int cap = 1;
	public static int expNextLeVel;
	public int expHienTai;
	public static int trangthai=0; //0 = pause 1= resume
	public static float maxHealth;
	public static float health;
	void Start(){
		health = maxHealth;
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
