using UnityEngine;
using System.Collections;

public class Player2Controller : MonoBehaviour {

	public Vector2 moving = new Vector2();
	public Vector2 jumpForce = new Vector2(0, 300);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		print (rigidbody2D.velocity);
		moving.x = moving.y = 0;

		if (Input.GetKey ("right")){
			moving.x = 1;
		} else if (Input.GetKey("left")){
			moving.x = -1;
		}

		if (Input.GetKey ("up")){
			moving.y = 1;
		} else if (Input.GetKey("down")){
			moving.y = -1;
		}
		if (Input.GetKeyUp("space")||Input.GetMouseButtonUp(0)||Input.acceleration.z>0.5)
		{
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce(jumpForce);

		}
	}
}
