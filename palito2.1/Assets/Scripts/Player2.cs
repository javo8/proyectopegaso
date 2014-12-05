using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {

	// Use this for initialization
	public float speed = 10f;
	public Vector2 maxVelocity = new Vector2(3,5);
	public bool standing;
	public float velsalto = 20f;
	public float airSpeedMultiplier = .3f;
	public Vector2 jumpForce = new Vector2(0, 300);
	public static int muerto = 0;

	private Animator animator;
	private Player2Controller controller;

	void Start(){
		controller = GetComponent<Player2Controller> ();
		animator = GetComponent<Animator> ();
	}
		
	// Update is called once per frame
	void Update () {
		rigidbody2D.velocity = new Vector2(0,rigidbody2D.velocity.y);
		if (transform.position.y < -3.5&&muerto==0) {
			rigidbody2D.velocity = Vector2.zero;
			transform.position = new Vector3(transform.position.x,(float)-3.5, transform.position.z);
		}
		if (muerto == 1) {
						transform.rotation = new Quaternion (0, 0, 45, 0);
						rigidbody2D.velocity = new Vector2 (0, rigidbody2D.velocity.y);
						//yield return new WaitForSeconds(3);
						//Destroy(gameObject);
			
				} else {
						transform.rotation = new Quaternion (0, 0, 0, 0);
				}
		var forceX = 0f;
		var forceY = 0f;

		var absVelx = Mathf.Abs (rigidbody2D.velocity.x);
		var absVelY = Mathf.Abs (rigidbody2D.velocity.y);

		if (absVelY < .2f) {
				standing = true;
		} else {
				standing = false;
		}

		//if(controller.moving.x !=0) {
		//	if (absVelx < maxVelocity.x){
		//		forceX= standing ? speed * controller.moving.x : (speed * controller.moving.x * airSpeedMultiplier);
		//	} 
		//	if (absVelY < 0.8) {
		//		animator.SetInteger("AnimState",0);
		//	}
		//} 
		if (rigidbody2D.velocity.y < -0.3) {
						animator.SetInteger ("AnimState", 2);
				}
		
		else if (rigidbody2D.velocity.y > 0) {
			animator.SetInteger ("AnimState", 1);
		}
		else if (rigidbody2D.velocity.y == 0||rigidbody2D.velocity.y == -0.3){
			animator.SetInteger ("AnimState", 0);
		}
		if(Player2.muerto==1)animator.SetInteger ("AnimState", 3);

	//	if (controller.moving.y > 0){
	//		if (absVelY < maxVelocity.y)
	//			forceY = velsalto * controller.moving.y;
	//		animator.SetInteger("AnimState",1);
	//	} else if (rigidbody2D.velocity.y > 0) {
	//		animator.SetInteger("AnimState",2);
		//
		//} else if (absVelY < 0.8) {
		//	animator.SetInteger("AnimState",0);
	//	}
	//	rigidbody2D.AddForce (new Vector2 (forceX, forceY));


	}
}
