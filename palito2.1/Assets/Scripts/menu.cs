using UnityEngine;
using System.Collections;
using UnityEngine;
using System.Collections;
//using GeoUtility;
//using GeoUtility.GeoSystem;

public class menu : MonoBehaviour {
	public Texture tienda;
	public Texture jugar;
	public Texture cerrar;
	public Texture puntajes;
	public GUIStyle buttonstyle;

	// Use this for initialization
	IEnumerator Start () {if (Input.location.isEnabledByUser) {
					

		
						Input.location.Start ();
						int maxWait = 20;
						while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0) {
								yield return new WaitForSeconds (1);
								maxWait--;
						}
				}
				
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI () {
		GUILayout.BeginArea(new Rect(Screen.width / 2 + Screen.width / 10, Screen.height/ 2, 440, 440));


		GUILayout.BeginHorizontal();
		if (GUILayout.Button (jugar, buttonstyle, GUILayout.Height (100), GUILayout.Width (100))) {
			Application.LoadLevel ("pal");Player.muerto=0;
			if(Input.location.lastData.longitude<Input.location.lastData.longitude){Application.LoadLevel ("pal");Player.muerto=0;}
			Generar.tiempo=0;
			Generar.monedas=0;};
		GUILayout.Space(20);
		GUILayout.Button(tienda, buttonstyle, GUILayout.Height(100),GUILayout.Width(100));
		GUILayout.Space(20);
		GUILayout.EndHorizontal();
		GUILayout.BeginHorizontal();
		GUILayout.Button(puntajes, buttonstyle, GUILayout.Height(100),GUILayout.Width(100));
		GUILayout.Space(20);
		if (GUILayout.Button (cerrar, buttonstyle, GUILayout.Height (100), GUILayout.Width (100))) {
			Application.Quit();};
		GUILayout.Space(20);
		GUILayout.EndHorizontal();

		GUILayout.EndArea();
		//if (GUI.Button (new Rect (Screen.width / 2 - Screen.width / 6, Screen.height / 2, 60, 60), tienda)) {
		//	Application.LoadLevel ("pal");
		//};
		
		
		//if (GUI.Button (new Rect (Screen.width / 2 - Screen.width / 3, Screen.height / 2, 60, 60), jugar)) {
//			Application.LoadLevel ("pal");
//		};
		
//		
//		if (GUI.Button (new Rect (Screen.width / 2 - Screen.width / 12, Screen.height / 2, 60, 60), cerrar)) {
//			Application.LoadLevel ("pal");}
	}
	}
