using UnityEngine;
using System.Collections;

public class buttonmngr : MonoBehaviour {

	public GameObject buttonarms;
	public GameObject buttonlegs;
	public GameObject buttonhead;
	private Vector3 orgPos; 

	// Use this for initialization
	void Start () {
		Instantiate (buttonarms);
		Instantiate (buttonlegs);
		Instantiate (buttonhead);
		orgPos = buttonarms.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void CreateButtonArms()
	{
		Instantiate (buttonarms, orgPos,Quaternion.identity);
	}

	void CreateButtonBody()
	{
		
	}

	void CreateButtonHead()
	{
		
	}
}
