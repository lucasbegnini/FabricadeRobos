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
	}



	void OnGUI()
	{
		if(paused)
		{
			GUILayout.Label("Jogo Parado!");
			if(GUILayout.Button("Click aqui para continuar"))
				paused = togglePause();
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