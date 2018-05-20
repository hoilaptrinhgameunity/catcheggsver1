using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class EggCollider : MonoBehaviour {

	PlayerScript myPlayerScript;

    void Awake()
    {
		myPlayerScript = myPlayerScript = transform.parent.GetComponent<PlayerScript>();
    }

	void OnTriggerEnter(Collider theCollision)
    {
		//In this game we don't need to check *what* we hit; it must be the eggs
        GameObject collisionGO = theCollision.gameObject;
        //Destroy(collisionGO);
		collisionGO.GetComponent<EggScript>().Tieuhuy();

		if (theCollision.gameObject.name == "Rocket3") {
			GameMNG.health = 0f;
		}
		else if (theCollision.gameObject.name == "Egg") {
			GameObject.Find ("GameManager").GetComponent<GameMNG> ().expHienTai++;
			GameObject.Find ("GameManager").GetComponent<GameMNG> ().theScore++;
			AudioSource audio = GameObject.Find("GameManager").GetComponent<AudioSource>();
			audio.Play();

		}
	}
}
