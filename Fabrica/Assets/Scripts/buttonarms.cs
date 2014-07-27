using UnityEngine;
using System.Collections;

public class buttonarms : MonoBehaviour {

	private Vector3 offset;
	private Vector3 orgPos;
	public GameObject _ButtonMngr;


	// Use this for initialization
	void Start () {
		orgPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(
			new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f )); 
	}
	
	void OnMouseDrag()
	{
		Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0f); 
		Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
		transform.position = curPosition;
	}

	void OnMouseUp()
	{
		transform.position = orgPos;
	} 

	void OnTriggerEnter2D(Collider2D other)
	{
		_ButtonMngr.SendMessage ("CreateButtonArms");
		Object.Destroy(this.gameObject);

	}

}
