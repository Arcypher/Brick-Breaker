using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	const string DIFFICULTY_KEY = "difficulty";

    public void LoadScene(string name) {
    	if (name.Equals("Difficulty Choice")) {
	        Debug.Log("Choose your difficulty!");
			SceneManager.LoadScene(name);
		} else if (name.Equals("Easy Mode")) {
			Debug.Log("This is Easy");
			PlayerPrefsManager.SetDifficulty(1f);
	        SceneManager.LoadScene(name);
		} else if (name.Equals("Medium Mode")) {
			Debug.Log("This is Medium");
	        PlayerPrefsManager.SetDifficulty(2f);
	        SceneManager.LoadScene(name);
		} else if (name.Equals("Hard Mode")) {
			Debug.Log("This is Hard");
			PlayerPrefsManager.SetDifficulty(3f);
	        SceneManager.LoadScene(name);
		} else if (name.Equals("Menu")) {
			SceneManager.LoadScene(name);
		}
    }

    public void LoadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
