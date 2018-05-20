using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	void Update () {
        //These two lines are all there is to the actual movement..
        float moveInput = Input.GetAxis("Horizontal") * Time.deltaTime * 3; 
        transform.position += new Vector3(moveInput, 0, 0);

        //Restrict movement between two values
        if (transform.position.x <= -2.5f || transform.position.x >= 2.5f)
        {
            float xPos = Mathf.Clamp(transform.position.x, -2.5f, 2.5f); //Clamp between min -2.5 and max 2.5
            transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
        }
	}
}