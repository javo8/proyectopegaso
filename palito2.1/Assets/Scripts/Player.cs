using UnityEngine;

public class Player : MonoBehaviour
{
	// The force which is added when the player jumps
	// This can be changed in the Inspector window
	public Vector2 jumpForce = new Vector2(0, 300);
	public static int muerto = 0;
	//public float piso=-3.5;
	// Update is called once per frame
	void Update ()
	{
		rigidbody2D.velocity = new Vector2(0,rigidbody2D.velocity.y);
				if (transform.position.y < -3.5&&muerto==0) {
				
			transform.position = new Vector3(transform.position.x,(float)-3.5, transform.position.z);
		}
		if (muerto == 1) {
			transform.rotation = new Quaternion (0, 0, 45, 0);
			rigidbody2D.velocity = new Vector2 (0, rigidbody2D.velocity.y);

		} else {transform.rotation = new Quaternion (0, 0, 0, 0);

		}
	
		// Jump
		if (Input.GetKeyUp("space")||Input.GetMouseButtonUp(0)||Input.acceleration.z>0.5)
		{print(Input.acceleration.z);
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce(jumpForce);
		}
	
		
	
	
	
	}


}