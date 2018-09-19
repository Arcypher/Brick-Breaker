using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	private int scoreValue = 1;
	private ScoreKeeper scoreKeeper;

	// Use this for initialization
	void Start() {
		scoreKeeper = GameObject.Find("Score").GetComponent<ScoreKeeper>();
	}

	public void OnMouseDown() {
        Debug.Log("I'm touching the brick");
        Destroy(gameObject);
        Tapped();
    }

    void Tapped() {
		scoreKeeper.Score(scoreValue);
    }
}
