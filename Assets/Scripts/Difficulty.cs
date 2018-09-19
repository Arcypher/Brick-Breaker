using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Difficulty : MonoBehaviour {

	const string DIFFICULTY_KEY = "difficulty";

    public void Easy(string name) {
        Debug.Log("This is Easy");
        SetDifficulty(1f);
        SceneManager.LoadScene(name);
    }

    public void Medium(string name) {
        Debug.Log("This is Medium");
        SetDifficulty(2f);
        SceneManager.LoadScene(name);
    }

    public void Hard(string name) {
        Debug.Log("This is Hard");
        SetDifficulty(3f);
        SceneManager.LoadScene(name);
    }

	public void SetDifficulty (float difficulty) {
		if (difficulty >= 1f && difficulty <= 3f) { 
			PlayerPrefs.SetFloat (DIFFICULTY_KEY, difficulty);
		} else {
			Debug.LogError("Master difficulty out of range");
		}
	}

	public float GetDifficulty () {
		return PlayerPrefs.GetFloat (DIFFICULTY_KEY);
	}
}
