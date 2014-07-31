using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	
	public AudioClip Sound;

	void Start () {
	
	}
	
	// Update is called once per frame


	void OnGUI()
	{
		GUI.color = Color.black;
	

		DrawButtons ();
		

	}
	
	void ResetScore()
	{
		PlayerPrefs.SetInt ("highscore", 0);
	}

	void backToGame()
	{
		Application.LoadLevel("game");
	}

	void backToMenu()
	{
		Application.LoadLevel("start");
	}

	void DrawButtons()
	{
		GUIStyle EstiloButton;
			EstiloButton = LoadStyleButton ();
		GUIStyle EstiloLabel;
		EstiloLabel = LoadStyleLabel ();


		GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
		GUILayout.FlexibleSpace();
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		
		GUILayout.Label ("Seu Score foi: " + PlayerPrefs.GetInt("yourscore").ToString(),EstiloLabel );
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		GUILayout.Label ("O maior Score : " + PlayerPrefs.GetInt("highscore").ToString(), EstiloLabel );
		
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		

		GUI.color = Color.magenta;
		if (GUILayout.Button ("Volte para o jogo ", EstiloButton))
		{
			//float tempo = Time.time;	
			//audio.PlayOneShot(Sound);
			
			backToGame ();
			
		}
			
		
		
		GUILayout.Space (10);
		if (GUILayout.Button (" Menu ", EstiloButton))
		{
			//audio.PlayOneShot(Sound);
			backToMenu ();
		}


			

		GUILayout.Space (10);
		if (GUILayout.Button (" Reiniciar Score ", EstiloButton))
		{
			ResetScore ();
			audio.PlayOneShot(Sound);
		}



			
		
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		
		
		GUILayout.FlexibleSpace();
		GUILayout.EndArea();

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

	GUIStyle LoadStyleLabel()
	{	
		
		GUIStyle MyStyle;
		MyStyle = new GUIStyle (GUI.skin.label);
		MyStyle.fontSize = 50;
		// Load and set Font
		Font myFont = (Font)Resources.Load("Fonts/pixelli", typeof(Font));
		MyStyle.font = myFont;
		
		
		return MyStyle;
	}
	
}
