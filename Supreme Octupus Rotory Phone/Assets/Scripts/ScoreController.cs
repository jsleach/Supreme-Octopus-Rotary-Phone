using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreController : MonoBehaviour {

	public Text scoreText;
	private int score = 0;

	// Use this for initialization
	public void Awake() {
		Phone.onPhoneClick += this.updateScore;
	}

	public void Start() {
		scoreText.text = "Score: " + score;
	}

	public void updateScore() {
		score++;
		scoreText.text = "Score: " + score;
	}
}
