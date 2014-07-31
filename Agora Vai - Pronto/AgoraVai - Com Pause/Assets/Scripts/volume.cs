using UnityEngine;
using System.Collections;

public class volume : MonoBehaviour {

	bool sound = false;
	void OnMouseDown()
	{
		if (sound) {
			AudioListener.pause = true;
			sound = false;
		}

		if (!sound) {
			AudioListener.pause = false;	
		}
						

	}



}
