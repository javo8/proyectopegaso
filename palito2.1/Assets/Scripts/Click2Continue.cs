using UnityEngine;
using System.Collections;

public class Click2Continue : MonoBehaviour {

	public string scene;
	private bool loadlock;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp(0) && !loadlock)
			LoadScene();
	}
	
		void LoadScene(){
			loadlock = true;
			Application.LoadLevel(scene);
	}
}
