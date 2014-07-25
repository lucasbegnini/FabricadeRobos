using UnityEngine;
using System.Collections;

public class units : MonoBehaviour {

	public Vector2 velocity = new Vector2(-4,0);
	public GameObject noarms;
	public GameObject nohead;
	public GameObject nolegs;
	
	int unit;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("CreateUnits", 1f, 1f); 

	}
	
	// Update is called once per frame
	void Update () {

	}

	void CreateUnits(){
		unit = Random.Range (1, 4);
		switch (unit) {
		case 1:
				Instantiate (noarms);
			break;

		case 2:
				Instantiate (nohead);
			break;

		case 3:
				Instantiate (nolegs);
			break;
		}
	}
}
