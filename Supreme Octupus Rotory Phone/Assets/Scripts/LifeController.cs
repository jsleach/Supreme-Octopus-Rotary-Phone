using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LifeController : MonoBehaviour {

	public int startingLives =3 ;
	public int maxLives = 5;
	public Text lifeText;

	private int currentLives;

	void Awake() {
		Phone.onPhoneDeath += loseLife;
	}

	// Use this for initialization
	void Start () {
		currentLives = startingLives;
		updateLives ();
	}

	void updateLives() {
		lifeText.text = "Lives: " + currentLives;
	}

	void loseLife() {
		currentLives--;
		updateLives ();

		if (currentLives <= 0) {
			SceneManager.LoadScene ("GameOverMenu");
		}
	}
}
