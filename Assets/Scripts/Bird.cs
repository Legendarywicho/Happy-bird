using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bird : MonoBehaviour {


	private bool isDead = false;
	private Animator anim;
	private Rigidbody2D rb2D;
	public float upforce=200f;


	// Use this for initialization
	void Start () {

		rb2D = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {

		if (isDead == false) {

			if (Input.GetMouseButtonDown (0)) {

				rb2D.velocity = Vector2.zero;
				rb2D.AddForce (new Vector2 (0,upforce));
				anim.SetTrigger ("Flat");
			}

		}

	}

	void OnCollisionEnter2D(){

		isDead = true;
		anim.SetTrigger ("Die");
		rb2D.velocity = (Vector2.zero);
		GameControl.instance.BirdDied ();

	}


}
