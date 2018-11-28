using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	public PlayerScript playerScript;

	// Use this for initialization
	void Start () {
		playerScript = Object.FindObjectOfType<PlayerScript> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name.Equals ("wallBottom")) {
			playerScript.gameOver = true;
		}
	}
}
