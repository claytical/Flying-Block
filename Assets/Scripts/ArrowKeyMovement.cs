using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowKeyMovement : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// FixedUpdate is called at a fixed interval
	void FixedUpdate () {
		if (Input.GetKey(KeyCode.UpArrow)) {
			transform.Translate(Vector3.forward * speed);
		}
		if (Input.GetKey(KeyCode.DownArrow)){
			transform.Translate(Vector3.back * speed);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate(Vector3.left * speed);

		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate(Vector3.right * speed);
		}

	}
}
