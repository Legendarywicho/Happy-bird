using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

	public static GameControl instance;
	public GameObject gameOverText;
	public bool GameOver = false;
	public float scroolSpeed = -1.5f;
	private int score = 0;
	public Text scoreText;



	public  void BirdDied(){

		gameOverText.SetActive (true);
		GameOver = true;
	}


	void Start(){

		gameOverText.SetActive (false);
	
	}


	// Use this for initialization
	void Awake () {
		if(instance==null){
			instance=this;
		}

		else if(instance!=null){
			Destroy (gameObject);
		}


	}


	public void BirdScore()
	{

		if (GameOver) {
		
			return;
		}
		score++;
		scoreText.text = " Score: " + score.ToString();
	}

	// Update is called once per frame
	void Update () {

		if (GameOver == true && Input.GetMouseButtonDown (0)) {
						
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);

		} 

	}
}
