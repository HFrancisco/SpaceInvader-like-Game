using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

	public int killCount = 0;

	public BulletScript bulletScript;

	public GameObject alienPrefab;

	public GameObject prefabAlienContainer;
	public GameObject spawnAlienContainer;

	public GameObject spawnRow1Pos1;
	public GameObject spawnRow1Pos2;
	public GameObject spawnRow1Pos3;
	public GameObject spawnRow1Pos4;
	public GameObject spawnRow1Pos5;

	public GameObject spawnRow2Pos1;
	public GameObject spawnRow2Pos2;
	public GameObject spawnRow2Pos3;
	public GameObject spawnRow2Pos4;
	public GameObject spawnRow2Pos5;

	public GameObject spawnRow3Pos1;
	public GameObject spawnRow3Pos2;
	public GameObject spawnRow3Pos3;
	public GameObject spawnRow3Pos4;
	public GameObject spawnRow3Pos5;

	public GameObject spawnRow4Pos1;
	public GameObject spawnRow4Pos2;
	public GameObject spawnRow4Pos3;
	public GameObject spawnRow4Pos4;
	public GameObject spawnRow4Pos5;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (killCount == 40) {
			Instantiate (prefabAlienContainer, spawnAlienContainer.transform.position, Quaternion.identity);
			killCount = 0;
		}
	}

	void ins(){

		Instantiate(alienPrefab, spawnRow1Pos1.transform.position, Quaternion.Euler(0, 180, 0));
		Instantiate(alienPrefab, spawnRow1Pos2.transform.position, Quaternion.Euler(0, 180, 0));
		Instantiate(alienPrefab, spawnRow1Pos3.transform.position, Quaternion.Euler(0, 180, 0));
		Instantiate(alienPrefab, spawnRow1Pos4.transform.position, Quaternion.Euler(0, 180, 0));
		Instantiate(alienPrefab, spawnRow1Pos5.transform.position, Quaternion.Euler(0, 180, 0));
		Instantiate(alienPrefab, spawnRow2Pos1.transform.position, Quaternion.Euler(0, 180, 0));
		Instantiate(alienPrefab, spawnRow2Pos2.transform.position, Quaternion.Euler(0, 180, 0));
		Instantiate(alienPrefab, spawnRow2Pos3.transform.position, Quaternion.Euler(0, 180, 0));
		Instantiate(alienPrefab, spawnRow2Pos4.transform.position, Quaternion.Euler(0, 180, 0));
		Instantiate(alienPrefab, spawnRow2Pos5.transform.position, Quaternion.Euler(0, 180, 0));
		Instantiate(alienPrefab, spawnRow3Pos1.transform.position, Quaternion.Euler(0, 180, 0));
		Instantiate(alienPrefab, spawnRow3Pos2.transform.position, Quaternion.Euler(0, 180, 0));
		Instantiate(alienPrefab, spawnRow3Pos3.transform.position, Quaternion.Euler(0, 180, 0));
		Instantiate(alienPrefab, spawnRow3Pos4.transform.position, Quaternion.Euler(0, 180, 0));
		Instantiate(alienPrefab, spawnRow3Pos5.transform.position, Quaternion.Euler(0, 180, 0));
		Instantiate(alienPrefab, spawnRow4Pos1.transform.position, Quaternion.Euler(0, 180, 0));
		Instantiate(alienPrefab, spawnRow4Pos2.transform.position, Quaternion.Euler(0, 180, 0));
		Instantiate(alienPrefab, spawnRow4Pos3.transform.position, Quaternion.Euler(0, 180, 0));
		Instantiate(alienPrefab, spawnRow4Pos4.transform.position, Quaternion.Euler(0, 180, 0));
		Instantiate(alienPrefab, spawnRow4Pos5.transform.position, Quaternion.Euler(0, 180, 0));
	}
}
