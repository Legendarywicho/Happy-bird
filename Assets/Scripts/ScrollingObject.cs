using UnityEngine;
using System.Collections;

public class ScrollingObject : MonoBehaviour {


	private Rigidbody2D Scroll;


	// Use this for initialization
	void Start () {
	

		Scroll = GetComponent<Rigidbody2D> ();
		Scroll.velocity = new Vector2 (GameControl.instance.scroolSpeed, 0);
	}
	
	// Update is called once per frame
	void Update () {

		if (GameControl.instance.GameOver == true) {
		
		
			Scroll.velocity = Vector2.zero;
		
		}


	}
}
