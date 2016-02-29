using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreController : MonoBehaviour {

	public Text scoreText;
	private int score = 0;

	// Use this for initialization
	void Awake() {
		Phone.onPhoneClick += this.updateScore;
	}

	void Start() {
		scoreText.text = "Score: " + score;
	}

	void updateScore() {
		score++;
		scoreText.text = "Score: " + score;
		PlayerPrefs.SetInt ("Current Score", score);
	}
}
