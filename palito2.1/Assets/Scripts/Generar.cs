using UnityEngine;

public class Generar : MonoBehaviour
{	public Texture boton;
	public Texture menu;
	public GameObject moneda;
	public GameObject box;
	public static float tiempo=0;
	public static int monedas;
	public GUIStyle buttonstyle;
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", 1f, 1.5f);
	}
	void OnGUI () 
	{
		GUI.color = Color.blue;
		if (Player.muerto == 0) {
			tiempo=	Time.timeSinceLevelLoad+monedas*5;	}
		//print (tiempo);
		//GUI.Label (new Rect (10, 10, 100, 20), "Hello World!");
		if (Player.muerto == 0){GUI.Label (new Rect (10, 15, 200, 20),( " puntuacion: " + tiempo.ToString()));}
		if (Player.muerto == 1){GUI.Label(new Rect(Screen.width / 2-Screen.width / (float)7, Screen.height/2-Screen.height/9, 200, 20),("puntuacion: " + tiempo.ToString()));
			GUI.Label(new Rect(Screen.width / 2-Screen.width / 8, Screen.height / 2-Screen.height / 6, 100, 20),"juego terminado ");


		//	if (GUI.Button(new Rect(Screen.width / 2-Screen.width / 12,Screen.height/2, 60, 60), boton)){
		//		//print(Application.loadedLevelName);
		//		Player.muerto=0;
		//		tiempo=0;
		//		monedas=0;
		//		Application.LoadLevel ("pal");

		//	}
			GUILayout.BeginArea(new Rect(Screen.width / 4 + Screen.width / 10, Screen.height/ 2, 250, 220));
			GUILayout.BeginHorizontal();
			if (GUILayout.Button (boton, GUILayout.Height (100), GUILayout.Width (100))) {
				Player.muerto=0;
						tiempo=0;
						monedas=0;
				Application.LoadLevel ("pal");};
			GUILayout.Space(20);
			if (GUILayout.Button (menu, GUILayout.Height (100), GUILayout.Width (100))) {
				Application.LoadLevel ("menu");};
			GUILayout.Space(20);
			GUILayout.EndHorizontal();
			GUILayout.EndArea();
		}
	}
	void CreateObstacle()
	{ if (Player.muerto != 1) {
						Instantiate (box);
			Instantiate (moneda);
				}
	}
}