using UnityEngine;
using System.Collections;

public class Phone : MonoBehaviour {

	public float timeToLive;

	public delegate void PhoneHandler();
	public static event PhoneHandler onPhoneClick;
	public static event PhoneHandler onPhoneDeath;

	private float createdTime;

	// Use this for initialization
	void Start () {
		createdTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - createdTime >= timeToLive) {
			phoneDeath ();
		}
	}

	void OnMouseDown() {
		phoneClick ();
		Destroy (gameObject);
	}

	public static void phoneClick() {
		if (onPhoneClick != null) {
			onPhoneClick ();
		}
	}

	public void phoneDeath() {
		if (onPhoneDeath != null) {
			onPhoneDeath ();
		}
		Destroy (gameObject);
	}
}
