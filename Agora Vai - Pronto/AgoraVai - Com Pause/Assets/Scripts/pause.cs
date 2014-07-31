using System;
using UnityEngine;

public class pause : MonoBehaviour
{
	bool paused = false;
	
	void Update()
	{
		
		
	}
	
	void OnMouseDown()
	{
		paused = togglePause();
		audio.Play ();
	}
	
	
	
	void OnGUI()
	{
		if(paused)
		{
			bool play;
			GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
			GUILayout.FlexibleSpace();
			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();
			GUILayout.Label("Jogo Parado!");
			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();

			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();

			play = GUILayout.Button("Click aqui para continuar");

			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			GUILayout.FlexibleSpace();
			GUILayout.EndArea();


			if(play)
			{
				paused = togglePause();
				audio.Play();
			}
		}
	}
	
	bool togglePause()
	{
		if(Time.timeScale == 0f)
		{
			Time.timeScale = 1f;
			return(false);
		}
		else
		{
			Time.timeScale = 0f;
			return(true);   
		}
	}
}