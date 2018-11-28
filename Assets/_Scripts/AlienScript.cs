using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienScript : MonoBehaviour {

	public PlayerScript playerScript;
	public float speed = .1f;

	private Transform trans;
	private int time;
	private float initZ = 0f;

	private bool moveLeft = true;
	private bool moveRight = false;
	private bool canMoveLeft = true;
	private bool canMoveRight = true;

	// Use this for initialization
	void Start () {
		trans = transform;
		playerScript = Object.FindObjectOfType<PlayerScript> ();
		time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (!(playerScript.gameOver)) {
			if (canMoveLeft == true && moveLeft == true) {
				trans.position = new Vector3 (trans.position.x, 0.1f, initZ) + (new Vector3 (-1, 0, 0) * speed);
			} else if (canMoveRight == true && moveRight == true) {
				trans.position = new Vector3 (trans.position.x, 0.1f, initZ) + (new Vector3 (1, 0, 0) * speed);
			}
		}
	}

	void OnCollisionEnter(Collision col){

		if (col.gameObject.name.Equals ("wallLeft")) {
			initZ = initZ - 0.25f;

			if(speed < 0.2)
				speed = speed + 0.01f;
			
			canMoveLeft = false;
			moveLeft = false;
			moveRight = true;
		} else if (col.gameObject.name.Equals ("wallRight")) {
			initZ = initZ - 0.25f;

			if(speed < 0.2)
				speed = speed + 0.01f;
			
			canMoveRight = false;
			moveLeft = true;
			moveRight = false;
		}

	}

	void OnCollisionExit(Collision col){
		if (col.gameObject.name.Equals ("wallLeft")) {
			canMoveLeft = true;
		} else if (col.gameObject.name.Equals ("wallRight")) {
			canMoveRight = true;
		}
	}
}
