using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {

    public Transform eggPrefab;
	public Transform EggPrefabBoom;
    private float nextEggTime = 0.0f;
	public static float spawnRate;
	void Update () {
		if (GameMNG.trangthai == 1) {
			if (nextEggTime < Time.time) {
				SpawnEgg ();
				nextEggTime = Time.time + spawnRate;
				/*
            //Speed up the spawnrate for the next egg
            spawnRate *= 0.98f;
            spawnRate = Mathf.Clamp(spawnRate, 0.3f, 99f);*/
			}
		}
	}

    void SpawnEgg()
    {		
        float addXPos = Random.Range(-1.6f, 1.6f);
        Vector3 spawnPos = transform.position + new Vector3(addXPos,0,0);
		int soegg = Random.Range (0, 4);
		if(soegg==3)
		{
			Instantiate(EggPrefabBoom, spawnPos, Quaternion.identity);
		}
		else
		{
			Instantiate(eggPrefab, spawnPos, Quaternion.identity);
		}
    }
}
