using UnityEngine;
using System.Collections;

public class volume : MonoBehaviour {

	bool sound = true;
	void OnMouseDown()
	{
	

		if (sound) {
		
			AudioListener.pause = true;
			sound = false;

		}else if (!sound) {
		
			AudioListener.pause = false;
			sound = true;
		}
						

	}



}
