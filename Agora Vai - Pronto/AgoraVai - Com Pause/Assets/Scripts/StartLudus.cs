using UnityEngine;
using System.Collections;

public class StartLudus : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("GoToStart", 2);
	
	}
	
	// Update is called once per frame
	void GoToStart()
	{
		Application.LoadLevel ("start");
	}
}
