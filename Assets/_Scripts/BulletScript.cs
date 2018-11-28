using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {
	//public variables are exposed to the properties of
	//unity's interface
	public float speed;
	public SpawnScript spawnScript;
	public PlayerScript playerScript;
	//transform is declared as a variable because some documentation
	//states that transform as a variable calls a function internally
	//rather than an actual variable. To increase efficiency, we
	//declared a variable
	private Transform trans;
	//The start function is the function called once when the object
	//starts. Is used for initialization.
	void Start () {
		trans = transform;
		spawnScript = Object.FindObjectOfType<SpawnScript>();
		playerScript = Object.FindObjectOfType<PlayerScript>();
	}

	//The update function is called
	void Update () {
		//vectors are similar to points except they indicate
		//changes of direction similar to how slopes work in
		//linear equations of Algebra
		trans.position += new Vector3(0,0,1) * speed;
	}

	//This function will activate when a collision is made. But for
	//this to work, the bullet must have the following components:
	//the rigid body and the box collider, please uncheck gravity
	//otherwise it will fall.
	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag.Equals("Alien") || col.gameObject.name.Equals("Alien")){

			spawnScript.killCount++;
			playerScript.score++;
			print (spawnScript.killCount);
			Destroy(col.gameObject);
			Destroy (gameObject);
		}

		if(col.gameObject.name.Equals("wallTop")){
			Destroy(gameObject);
		}

	}
}
