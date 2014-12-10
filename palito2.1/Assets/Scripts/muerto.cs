using UnityEngine;
using System.Collections;

public class muerto : MonoBehaviour {
	public Texture boton;
	public Texture menu;
	public GameObject moneda;
	public GameObject box;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGui () {
		if (Player2.muerto == 1){GUI.Label(new Rect(Screen.width / 2-Screen.width / (float)7, Screen.height/2-Screen.height/9, 200, 20),("puntuacion: " + Generar.tiempo.ToString()));
			GUI.Label(new Rect(Screen.width / 2-Screen.width / 8, Screen.height / 2-Screen.height / 6, 100, 20),"juego terminado ");
	
		
		
			GUILayout.BeginArea(new Rect(Screen.width / 4 + Screen.width / 10, Screen.height/ 2, 250, 220));
			GUILayout.BeginHorizontal();
			if (GUILayout.Button (boton, GUILayout.Height (100), GUILayout.Width (100))) {
				Player2.muerto=0;
				Generar.tiempo=0;
				Generar.monedas=0;
				Application.LoadLevel ("pal");};
			GUILayout.Space(20);
			if (GUILayout.Button (menu, GUILayout.Height (100), GUILayout.Width (100))) {
				Player2.muerto=0;
				Generar.tiempo=0;
				Generar.monedas=0;
				Application.LoadLevel ("menu");
			};
			GUILayout.Space(20);
			GUILayout.EndHorizontal();
			GUILayout.EndArea();
		
		
		
		
		
		
		
		
		
		
		
		
		}
	}}
