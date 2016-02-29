using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TopScores : MonoBehaviour {

	public Text scoreList;
	int numTopScores;

	private TextGenerator _generator;
	private ArrayList _topScores;
	private TextGenerationSettings _settings;

	// Use this for initialization
	void Start () {
//		_topScores = new ArrayList(PlayerPrefsX.GetIntArray ("HighScores"));
		int[] i = {1, 4, 5, 2, 7};
		_topScores = new ArrayList (i);
		numTopScores = 8;
		displayTopScores();
	}

	public void refreshScores() {
		_topScores = new ArrayList(PlayerPrefsX.GetIntArray ("HighScores"));
		displayTopScores ();
	}

	public void displayTopScores() {
		_topScores.Sort ();
		_topScores.Reverse ();
		ArrayList tempScores;
		if (_topScores.Count > 0) { //This is probably unnecessary due to the GetRange dependent on array size
			if (_topScores.Count < numTopScores) {
				numTopScores = _topScores.Count;
			}
			tempScores = _topScores.GetRange (0, numTopScores); //Grabs the top scores
			string scoreString = ""; //Preps the score generation string
			int count = 0;
			foreach (int score in tempScores) {
				scoreString += (count + 1) + ". " + score + "\n\r";
				count++;
			}
			scoreList.text = scoreString;
		}
	}
}
