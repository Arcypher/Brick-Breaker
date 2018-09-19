using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawner : MonoBehaviour {

	public GameObject[] bricks;
	float randX; 
	Vector3 whereToSpawn;
	public float spawnRate = 0.1f;
	public float nextSpawn = 0f;
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextSpawn) {
			nextSpawn = Time.time + spawnRate;
			randX = Random.Range(-1.35f, 1.35f);
			whereToSpawn = new Vector3 (randX, transform.position.y, transform.position.z);
			GameObject brick = Instantiate (bricks[Random.Range(0, bricks.Length)], whereToSpawn, Quaternion.identity) as GameObject;
			brick.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-7f, 7f), 0);
		}
	}
}
