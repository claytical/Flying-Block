using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchLight : MonoBehaviour {
	private bool lights;
	public GameObject lightSource;

	// Use this for initialization
	void Start () {
		lights = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision)
	{
		Debug.Log ("Touching, Light On");
		lightSource.SetActive (true);
	}

	void OnCollisionExit(Collision collision)
	{
		Debug.Log ("No Longer Touching, Light Off");
		lightSource.SetActive (false);

	}

}
