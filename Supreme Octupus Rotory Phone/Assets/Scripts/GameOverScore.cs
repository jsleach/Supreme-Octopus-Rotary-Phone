using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverScore : MonoBehaviour {

	public Text finalScore;

	// Use this for initialization
	void Start () {
		finalScore.text = "Final score: " + PlayerPrefs.GetInt ("Current Score");
	}

}
