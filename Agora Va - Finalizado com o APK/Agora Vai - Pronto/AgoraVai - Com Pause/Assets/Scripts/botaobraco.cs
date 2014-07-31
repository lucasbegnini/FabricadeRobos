﻿using UnityEngine;
using System.Collections;

public class botaobraco : MonoBehaviour {

	private Vector3 offset;


	// Use this for initialization
	void Start () {
	
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
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f); 
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
		transform.position = curPosition;
	}

	void OnMouseUp()
	{
		SendMessageUpwards ("CriarBotaoBraco");
		GameObject.Destroy (this.gameObject);
	}

	void OnTriggerEnter2D(Collider2D obj)
	{
		//Debug.Log ("bateu");
		SendMessageUpwards ("CriarBotaoBraco");
		GameObject.Destroy (this.gameObject);
		if (obj.CompareTag ("sembraco")) 
		{
			SendMessageUpwards ("Score");
		}
	}


}
