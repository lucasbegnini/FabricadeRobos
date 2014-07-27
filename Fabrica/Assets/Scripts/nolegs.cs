using UnityEngine;
using System.Collections;

public class nolegs : MonoBehaviour {

	public Vector2 velocity = new Vector2(-4,0);
	public GameObject legs;
	public GameObject obj;

	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = velocity;
		legs.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -5) {
			Object.Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D obj){
		if (obj.name == "buttonbody") 
		{
			legs.SetActive (true);
		}
	} 
}
