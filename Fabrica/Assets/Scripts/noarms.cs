using UnityEngine;
using System.Collections;

public class noarms : MonoBehaviour {

	public Vector2 velocity = new Vector2(-4,0);
	public GameObject arms;
	public GameObject obj;

	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = velocity;
		arms.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
		if (transform.position.x < -5) {
			Object.Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D obj){
		if (obj.name == "buttonarm") 
		{
     		arms.SetActive (true);
		}
	} 
}
