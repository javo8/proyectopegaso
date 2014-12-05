using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {
	public Texture tienda;
	public Texture jugar;
	public Texture cerrar;
	public Texture puntajes;
	public GUIStyle buttonstyle;
	// Use this for initialization
	void Start () {

				
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI () {print ("asdasd");
		GUILayout.BeginArea(new Rect(Screen.width / 2 + Screen.width / 10, Screen.height/ 2, 440, 440));


		GUILayout.BeginHorizontal();
		if (GUILayout.Button (jugar, buttonstyle, GUILayout.Height (100), GUILayout.Width (100))) {
			Application.LoadLevel ("pal");Player.muerto=0;
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
