using UnityEngine;
using System.Collections;

public class MenuButton : MonoBehaviour {

	public Collider2D collider2D;
	public Animation animation;
	public string levelToLoad;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Vector3 wp = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			if (collider2D.OverlapPoint (wp)) {
				animation.Play ();
			}
		}

		if (Input.touchCount > 0) {
			Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
			if (collider2D.OverlapPoint(wp))
			{
				animation.Play ();
			}
		}
	}

	void LoadLevel () {
		UnityEngine.SceneManagement.SceneManager.LoadScene(levelToLoad);
	}
}
