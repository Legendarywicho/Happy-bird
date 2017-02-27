using UnityEngine;
using System.Collections;

public class RepetingBackground : MonoBehaviour {



	private BoxCollider2D groundColider;
	private float groundHorizontalLength;

	// Use this for initialization
	void Start () {

		groundColider = GetComponent<BoxCollider2D> ();
		groundHorizontalLength = groundColider.size.x;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (transform.position.x < -groundHorizontalLength) {
		
			Position ();
		
		}

		}


	private void Position(){
	
		Vector2 offset = new Vector2 (groundHorizontalLength*2f, 0);	
		transform.position = (Vector2)transform.position + offset;
	
	}
}


