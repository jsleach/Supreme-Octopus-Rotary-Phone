﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class UIButtonLevelLoad : MonoBehaviour {
	
	public string LevelToLoad;
	
	void OnMouseDown() {
		//Load the level from LevelToLoad
		SceneManager.LoadScene(LevelToLoad);
	}
}
