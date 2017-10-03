﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour {
	public List<string> inventory;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
        Collectable collectableFromOther = other.GetComponent<Collectable>();
        if(collectableFromOther != null) { 
			other.GetComponent<Collectable> ().Collect ();
			inventory.Add (other.GetComponent<Collectable> ().description);
		}
		GetComponent<LightUnlock> ().CheckInventory ();
	}

}
