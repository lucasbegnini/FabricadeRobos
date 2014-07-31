using UnityEngine;
using System.Collections;

public class StartGamer : MonoBehaviour {

void OnGUI()
	{
		GUI.color = Color.black;
		DrawButtons ();
	}


void DrawButtons()
	{
		GUI.color = Color.magenta;
		GUIStyle ButtonStyle;
		ButtonStyle = LoadStyleButton ();

		GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
		GUILayout.FlexibleSpace();
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();

		if (GUILayout.Button ("Start Game",ButtonStyle))
						GoToGame ();

		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		
		if (GUILayout.Button ("Creditos",ButtonStyle))
						GoToCreditos ();
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		
		if (GUILayout.Button ("Sair",ButtonStyle))
						GoToOut ();
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();

		GUILayout.FlexibleSpace();
		GUILayout.EndArea();
	}

void GoToGame()
	{
		Application.LoadLevel ("Game");
	}

	void GoToCreditos()
	{
		Application.LoadLevel ("Creditos");
	}

	void GoToOut()
	{
		Application.Quit ();
	}

	GUIStyle LoadStyleButton()
	{	
		
		GUIStyle MyStyle;
		MyStyle = new GUIStyle (GUI.skin.button);
		MyStyle.fontSize = 50;
		// Load and set Font
		Font myFont = (Font)Resources.Load("Fonts/pixelli", typeof(Font));
		MyStyle.font = myFont;
		
		
		return MyStyle;
	}
}