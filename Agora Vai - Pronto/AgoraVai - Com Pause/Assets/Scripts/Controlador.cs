using UnityEngine;
using System.Collections;

public class Controlador : MonoBehaviour {

	public GameObject sembracoPrefab;
	private GameObject sembraco;

	public GameObject sempernaPrefab;
	private GameObject semperna;

	public GameObject semcabecaPrefab;
	private GameObject semcabeca;

	public GameObject botaobracoPrefab;
	private GameObject botaobraco;

	public GameObject botaopernaPrefab;
	private GameObject botaoperna;

	public GameObject botaocabecaPrefab;
	private GameObject botaocabeca;

	private int robo;
	private int robosmortos;
	private int score;
	private int vida=3;
	private Vector2 velocidade = new Vector2 (3,0);




	// Use this for initialization
	void Start () {
		InvokeRepeating ("CriarRobos", 2f, 2f); 
		botaobraco = GameObject.Instantiate(botaobracoPrefab) as GameObject;
		botaobraco.transform.parent = this.transform;

		botaoperna = GameObject.Instantiate(botaopernaPrefab) as GameObject;
		botaoperna.transform.parent = this.transform;

		botaocabeca = GameObject.Instantiate(botaocabecaPrefab) as GameObject;
		botaocabeca.transform.parent = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnGUI(){

		DrawScore ();
		DrawLife ();


	
	}

	void CriarRobos(){
		robo = Random.Range (1, 4);
		switch (robo) {
		case 1:
			sembraco = GameObject.Instantiate(sembracoPrefab) as GameObject;
			sembraco.transform.parent = this.transform;
			sembraco.rigidbody2D.velocity = velocidade;

			break;
			
		case 2:
			semperna = GameObject.Instantiate(sempernaPrefab) as GameObject;
			semperna.transform.parent = this.transform;
			semperna.rigidbody2D.velocity = velocidade;
			break;
			
		case 3:
			semcabeca = GameObject.Instantiate(semcabecaPrefab) as GameObject;
			semcabeca.transform.parent = this.transform;
			semcabeca.rigidbody2D.velocity = velocidade;
			break;
		}
	}

	void ContarRobosMortos()
	{
		robosmortos++;
		if (robosmortos == 10) 
		{
			BroadcastMessage("MaisRapido");
			robosmortos = 0;
			velocidade = velocidade + new Vector2 (1.5f,0);
			sembraco.rigidbody2D.velocity = velocidade;
		}
	}

	void CriarBotaoBraco()
	{
		botaobraco = GameObject.Instantiate(botaobracoPrefab) as GameObject;
		botaobraco.transform.parent = this.transform;
	}

	void CriarBotaoPerna()
	{
		botaoperna = GameObject.Instantiate(botaopernaPrefab) as GameObject;
		botaoperna.transform.parent = this.transform;
	}

	void CriarBotaoCabeca()
	{
		botaocabeca = GameObject.Instantiate(botaocabecaPrefab) as GameObject;
		botaocabeca.transform.parent = this.transform;
	}


	void Score()
	{
		score++;
		//Debug.Log (score);
	}

	void MeusPesames()
	{
		vida--;
		if (vida <= 0) 
		{
			FimdeJogo();

		}
	}

	void StoreHighscore(int newHighscore)
	{
		int oldHighscore = PlayerPrefs.GetInt("highscore", 0);  
		if (newHighscore > oldHighscore) {
			PlayerPrefs.SetInt ("highscore", newHighscore);
			PlayerPrefs.SetInt("yourscore", newHighscore);
				} else {
			PlayerPrefs.SetInt("yourscore",newHighscore);		
		}
	}

	void FimdeJogo(){
		StoreHighscore (score);
		Application.LoadLevel("perdeu");
	}


	void DrawScore()
	{
		GUIStyle labelStyle = LoadStyleLabel ();
		GUI.color = Color.black;
		GUILayout.BeginArea(new Rect(0,0 , Screen.width, Screen.height));
		//GUILayout.FlexibleSpace();
		GUILayout.Space (10);
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		GUILayout.Label (" Score : " + score.ToString (),labelStyle);
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.FlexibleSpace();
		GUILayout.EndArea();
	}

	void DrawLife()
	{
		GUI.color = Color.black;
		GUIStyle labelStyle = LoadStyleLabel ();
		GUILayout.BeginArea(new Rect(0,0 , Screen.width, Screen.height));
		//GUILayout.FlexibleSpace();
		GUILayout.Space (10);
		GUILayout.BeginHorizontal();
		//GUILayout.FlexibleSpace();
		GUILayout.Space (10);
		GUILayout.Label (" Vidas : ", labelStyle);
		GUI.color = Color.red;
		GUILayout.Label( vida.ToString (),labelStyle);
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.FlexibleSpace();
		GUILayout.EndArea();

	}




	GUIStyle LoadStyleLabel()
	{	
		
		GUIStyle MyStyle;
		MyStyle = new GUIStyle (GUI.skin.label);
		MyStyle.fontSize = 35;
		// Load and set Font
		Font myFont = (Font)Resources.Load("Fonts/zorque", typeof(Font));
		MyStyle.font = myFont;
		
		
		return MyStyle;
	}

}

