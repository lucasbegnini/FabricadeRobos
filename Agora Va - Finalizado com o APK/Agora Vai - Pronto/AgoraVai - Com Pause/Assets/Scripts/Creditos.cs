using UnityEngine;
using System.Collections;

public class Creditos : MonoBehaviour {
	public Texture2D imagem;
	private GUIContent content;
	// Use this for initialization
	void Start () {
		//imagem = Resources.Load ("Assets/Sprites/facelogo.jpg");
		//content.image = imagem;
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnGUI()
	{
		DrawnNames ();
	}

	void DrawnNames()
	{
		//GUI.backgroundColor = new Color (0, 0, 0, 0);

		GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
		GUILayout.FlexibleSpace();

		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		GUILayout.Space (20);
		GUILayout.Label (" Luan Moraes ", LoadStyleLabel());
		GUILayout.Space (20);
		if (GUILayout.Button (imagem))
						Application.OpenURL ("https://www.facebook.com/luan.moraes.xs?fref=ts");
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		GUILayout.Space (20);
		GUILayout.Label (" Lucas Begnini ", LoadStyleLabel());
		GUILayout.Space (20);
		if (GUILayout.Button (imagem))
			Application.OpenURL ("https://www.facebook.com/lucas.begnini.7");
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		GUILayout.Space (20);
		GUILayout.Label (" Nara Quintela" , LoadStyleLabel());
		GUILayout.Space (20);
		if (GUILayout.Button (imagem))
			Application.OpenURL ("https://www.facebook.com/naraqb?fref=ts");
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		GUI.color = Color.magenta;
		if (GUILayout.Button ("Menu",LoadStyleButton()))
						GoToMenu ();
		GUILayout.Space (20);
		if (GUILayout.Button ("Play",LoadStyleButton()))
						GoToGame ();

		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();

		GUILayout.FlexibleSpace();
		GUILayout.EndArea();
	}

	void GoToGame()
	{
		Application.LoadLevel("game");
	}

	void GoToMenu()
	{
		Application.LoadLevel("start");
	}
	
	GUIStyle LoadStyleLabel()
	{	
		//GUI.color = Color.black;
		GUIStyle MyStyle;
		MyStyle = new GUIStyle (GUI.skin.label);
		MyStyle.fontSize = 35;
		// Load and set Font
		Font myFont = (Font)Resources.Load("Fonts/pixelli", typeof(Font));
		MyStyle.font = myFont;
		
		
		return MyStyle;
	}

	GUIStyle LoadStyleButton()
	{	
		
		GUIStyle MyStyle;
		MyStyle = new GUIStyle (GUI.skin.button);
		MyStyle.fontSize = 30;
		// Load and set Font
		Font myFont = (Font)Resources.Load("Fonts/pixelli", typeof(Font));
		MyStyle.font = myFont;
		
		
		return MyStyle;
	}
}
