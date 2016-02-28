using UnityEngine;
using System.Collections;

public class MeteredBar: MonoBehaviour {

	public float totalValue = 100f;
	public float currentValue = 50f;
	public float minimumValue = 0.0f;

	private RectTransform healthTransform;
	private Vector3 scaledVector;

	public delegate void FullBarHandler (string barName);
	public static event FullBarHandler OnFullBar;

	void Start() {
		healthTransform = this.gameObject.GetComponent<RectTransform> ();
		scaledVector = _GetScaledVector (healthTransform.localScale);

		healthTransform.localScale = 
			new Vector3 (scaledVector.x*currentValue, healthTransform.localScale.y, healthTransform.localScale.y);
	}

	public static void FullBar(string barName) {
		if (OnFullBar != null) {
			OnFullBar (barName);
		}
	}

	internal void DecrementHealthBar(float amt) {
		healthTransform.localScale = 
			new Vector3 (healthTransform.localScale.x - scaledVector.x, 
				healthTransform.localScale.y, healthTransform.localScale.y);
		this.currentValue--;
		//healthTransform.position = new Vector3(healthTransform.rect.width/2.0f, healthTransform.position.y, healthTransform.position.z);
	}

	internal void IncrementHealthBar(float amt) {
		healthTransform.localScale = 
			new Vector3 (healthTransform.localScale.x + scaledVector.x, 
				healthTransform.localScale.y, healthTransform.localScale.y);
		this.currentValue++;

		if (totalValue == currentValue) {
			FullBar (this.gameObject.name);
		}
		//healthTransform.position = new Vector3(healthTransform.rect.width/2.0f, healthTransform.position.y, healthTransform.position.z);
	}

	private Vector3 _GetScaledVector(Vector3 vector){
		return new Vector3 (vector.x / totalValue, vector.y / totalValue, vector.z);
	}
}
