using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameMode : MonoBehaviour {

	public Brick[] bricks;

	private bool isEasy = false;
	private bool isMedium = false;
	private bool isHard = false;

	// Use this for initialization
	void Start () {
		if (PlayerPrefsManager.GetDifficulty() == 1f) {
			Debug.Log ("Welcome to easy mode!");
			isEasy = true;
			Easy(isEasy);
		} else if (PlayerPrefsManager.GetDifficulty() == 2f) {
			Debug.Log ("Welcome to medium mode!");
			isMedium = true;
			Medium(isMedium);
		} else if (PlayerPrefsManager.GetDifficulty() == 3f) {
			Debug.Log ("Welcome to hard mode!");
			isHard = true;
			Hard(isHard);
		}
	}


	void Easy(bool easyCheck) {
		
	}

	void Medium(bool mediumCheck) {
		
	}

	void Hard(bool hardCheck) {

	}

	void Update () {

	}
}
