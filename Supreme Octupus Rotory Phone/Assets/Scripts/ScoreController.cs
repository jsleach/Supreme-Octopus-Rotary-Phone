using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreController : MonoBehaviour {

	public Text scoreText;

	private int score = 0;
	private int combo = 0;
	private int multiplier = 0;

	// Use this for initialization
	void Awake() {
		Phone.onPhoneClick += this.updateScore;
		Phone.onPhoneDeath += this.resetCombo;
	}

	void Start() {
		scoreText.text = "Score: " + score;
	}

	void updateScore() {
		combo++;
		if (combo < 110) {
			multiplier = (combo / 10) + 1;
		}
		score += multiplier;
		scoreText.text = "Score: " + score;
		PlayerPrefs.SetInt ("Current Score", score);
	}

	void resetCombo() {
		combo = 0;
		multiplier = 0;
	}
}
