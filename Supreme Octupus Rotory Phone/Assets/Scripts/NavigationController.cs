using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class NavigationController : MonoBehaviour {

	public enum sceneEnum {
		StartMenu,
		HighScore,
		Level
	};

	string[] sceneVals = {
		"StartMenu",
		"HighScore",
		"Level"
	};

	public sceneEnum input;

	private ArrayList scenes;

	public void Start () {
	}

	public void NavigateToScene() {
		SceneManager.LoadScene (input.ToString());
	}
}
