using UnityEngine;
using System.Collections;

public class Phone : MonoBehaviour {

	public float timeToLive;

	private float createdTime;

	// Use this for initialization
	void Start () {
		createdTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - createdTime >= timeToLive) {
			DestroyPhone ();
		}
	}

	void DestroyPhone() {
		Destroy (gameObject);
	}
}
