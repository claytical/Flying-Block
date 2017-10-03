using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {
	public string description;
	private Vector3 originalPosition;
	private Vector3 collectedPosition;
	private bool collected;

	// Use this for initialization
	void Start () {
		originalPosition = transform.position;
		collectedPosition = new Vector3 (originalPosition.x, originalPosition.y + 1, originalPosition.z + 2);
	}
	
	// Update is called once per frame
	void Update () {
		if (collected) {
			transform.position = Vector3.MoveTowards (transform.position, collectedPosition, 1f);
		}
	}

	public void Collect() {
		GetComponent<Animator> ().SetTrigger ("collected");
		collected = true;
	}
		
	public void RemoveObject() {
		Destroy (gameObject);
	}

}
