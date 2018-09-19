using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Shredder : MonoBehaviour {

	private int count = 0;
	// Use this for initialization
	void OnTriggerEnter2D (Collider2D collision) {
		count++;
		Debug.Log(count);
		Destroy(collision.gameObject);
		if (count == 5) {
			Lose();
		}
	}

	void Lose() {
		SceneManager.LoadScene("Lose Screen");
	}
}
