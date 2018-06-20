using UnityEngine;
using System.Collections;

public class EggScript : MonoBehaviour {
	//public Rigidbody rb;
	void Update () {
		float fallSpeed = 2 * Time.deltaTime;
		if (GameMNG.trangthai == 1) {
			gameObject.GetComponent<Rigidbody>().useGravity = true;
			transform.position -= new Vector3 (0, fallSpeed, 0);
			
		}
		if (GameMNG.trangthai == 0) {
			Tieuhuy();
		}
        if (transform.position.y < -1 || transform.position.y >= 20)
        {
            //Destroy this gameobject (and all attached components)
			Destroy (transform.parent.gameObject);
			if (transform.gameObject.name == "Egg") {
				GameMNG.health -= 1f;
				GameObject.Find ("GameManager").GetComponent<GameMNG> ().IncreaEggResult(0);
			}
        }
	}
	public void Tieuhuy()
	{
		Destroy (transform.parent.gameObject);
	}
}
