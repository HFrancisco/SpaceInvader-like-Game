using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

	public GameObject bulletPrefab;
	public int shotGap;
	public Text gameOverText;
	public Text scoreText;
	public int score = 0;
	public Button restartButton;

	private Transform trans;
	private int time;
	private bool canMoveLeft = true;
	private bool canMoveRight = true;
	public bool gameOver;

	void Start () {
		trans = transform;
		time = 0;			
		//restartButton.gameObject.SetActive (false);
		restartButton.interactable = false;
	}

	void Update () {
		scoreText.text = "Score: " + score/2;

		if (!(gameOver)) {
			//Input.GetAxis are default inputs given in unity
			float offsetX = Input.GetAxis ("Horizontal");
			if (offsetX < 0 && canMoveLeft == true) {
				trans.Translate (offsetX * 0.25f * -1, 0, 0);
			} else if (offsetX > 0 && canMoveRight == true) {
				trans.Translate (offsetX * 0.25f * -1, 0, 0);
			}

			//this is the axis for jump which is the space bar
			float fire = Input.GetAxis ("Jump");

			if (time < shotGap)
				time++;

			//1st - the object to be made
			//2nd - the placement of the object in reference to the ship
			//3rd - the angle of the spawn
			if (fire > 0) {

				if (time >= shotGap) {
					Instantiate (bulletPrefab, 
						new Vector3 (trans.position.x, 0.1f, -6f),
						Quaternion.Euler (0, 180, 0));

					time = 0;
				}
			}
		} else if (gameOver) {
			restartButton.interactable = true;
			gameOverText.text = "Game Over!";
		}
	}

	void OnCollisionEnter(Collision col){

		if (col.gameObject.name.Equals ("wallLeft")) {
			canMoveLeft = false;
		} else if (col.gameObject.name.Equals ("wallRight")) {
			canMoveRight = false;
		}

		if(col.gameObject.tag.Equals("Alien")){
			gameOver = true;
			//restartButton.gameObject.SetActive(true);
			//restartButton.onClick.AddListener(Restart);
			//Destroy(gameObject);
		}
	}

	void OnCollisionExit(Collision col){
		if (col.gameObject.name.Equals ("wallLeft")) {
			canMoveLeft = true;
		} else if (col.gameObject.name.Equals ("wallRight")) {
			canMoveRight = true;
		}
	}

	void Restart(){
		print ("Reset");
		SceneManager.LoadScene ("MainGame");
	}
}
