﻿using UnityEngine;
using System.Collections;

public class semcabeca : MonoBehaviour {

	public GameObject cabeca;
	private Vector2 veloatual;
	public GameObject obj;
	private bool ligado = false;

	
	// Use this for initialization
	void Start () {
		cabeca.SetActive (false);
		//veloatual = rigidbody2D.velocity;
		
	}
	
	// Update is called once per frame
	void Update () { 
		if (transform.position.x > 8) 
		{
			SendMessageUpwards("ContarRobosMortos");
			Object.Destroy (this.gameObject);
			if (!ligado)
			{
				SendMessageUpwards ("MeusPesames");
			}
		}
	}
	
	void MaisRapido()
	{
		veloatual = rigidbody2D.velocity;
		rigidbody2D.velocity = veloatual + new Vector2 (1.5f,0);
	}
	
	void OnTriggerEnter2D(Collider2D obj)
	{
		if(obj.CompareTag ("botaocabeca"))
		{
			cabeca.SetActive (true);
			ligado = true;
		}
	}
}