using UnityEngine;
using System.Collections;

public class WavyBackground : MonoBehaviour {
	public Vector2 Speed;

	private Renderer quadRenderer;

	public bool hasStarted;

	// Use this for initialization
	void Start () {
		quadRenderer = this.gameObject.GetComponent<Renderer> ();
	}

	void LateUpdate() {
		if(hasStarted) quadRenderer.material.mainTextureOffset = Speed * Time.time;
	}

	public void StartScreenMovement() {
		hasStarted = true;
	}

	public void PauseScreenMovement() {
		hasStarted = false;
	}
}