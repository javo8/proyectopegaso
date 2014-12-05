using UnityEngine;
using System.Collections;

public class movemoney : MonoBehaviour {
	public Vector2 velocity = new Vector2(-4, 0);
	public float range = 6;
	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = velocity;
		
		transform.position = new Vector3(transform.position.x+range * Random.value+7, (Random.value*8-3), transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
	
		if (transform.position.x < -10) {
			Destroy (gameObject);
		}
		
		if (Player2.muerto == 1) {
			
			rigidbody2D.velocity = new Vector2(0,0);
			if (transform.position.x > 2.6 && transform.position.x < 10) {//Destroy (gameObject);
			}}
	}
	
	void OnCollisionEnter2D(Collision2D player2)
	{Generar.monedas++;
		Destroy (gameObject);
	}
	
	
	
}




