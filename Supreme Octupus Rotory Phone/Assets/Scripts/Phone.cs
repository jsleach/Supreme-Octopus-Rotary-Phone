using UnityEngine;
using System.Collections;

public class Phone : MonoBehaviour {

	public float timeToLive;

	public delegate void ScoreHandler();
	public static event ScoreHandler onPhoneClick;

	private float createdTime;

	// Use this for initialization
	void Start () {
		createdTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - createdTime >= timeToLive) {
			destroyPhone ();
		}
	}

	void OnMouseDown() {
		phoneClick ();
		destroyPhone ();
	}

	public static void phoneClick() {
		if (onPhoneClick != null) {
			onPhoneClick ();
		}
	}

	void destroyPhone() {
		Destroy (gameObject);
	}
}
