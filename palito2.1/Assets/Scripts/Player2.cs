﻿using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {

	// Use this for initialization
	public float speed = 10f;
	public Vector2 maxVelocity = new Vector2(3,5);
	public bool standing;
	public float velsalto = 20f;
	public float airSpeedMultiplier = .3f;

	private Animator animator;
	private Player2Controller controller;

	void Start(){
		controller = GetComponent<Player2Controller> ();
		animator = GetComponent<Animator> ();
	}
		
	// Update is called once per frame
	void Update () {
		var forceX = 0f;
		var forceY = 0f;

		var absVelx = Mathf.Abs (rigidbody2D.velocity.x);
		var absVelY = Mathf.Abs (rigidbody2D.velocity.y);

		if (absVelY < .2f) {
				standing = true;
		} else {
				standing = false;
		}

		if(controller.moving.x !=0) {
			if (absVelx < maxVelocity.x){
				forceX= standing ? speed * controller.moving.x : (speed * controller.moving.x * airSpeedMultiplier);
			} 
			if (absVelY < 0.8) {
				animator.SetInteger("AnimState",0);
			}
		} 


		if (controller.moving.y > 0){
			if (absVelY < maxVelocity.y)
				forceY = velsalto * controller.moving.y;
			animator.SetInteger("AnimState",1);
		} else if (absVelY > 0) {
			animator.SetInteger("AnimState",2);

		} else if (absVelY < 0.8) {
			animator.SetInteger("AnimState",0);
		}
		rigidbody2D.AddForce (new Vector2 (forceX, forceY));


	}
}