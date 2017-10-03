using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightUnlock : MonoBehaviour {
	public GameObject light;
	public Collector player;

	public void CheckInventory() {
		int greenCount = 0;
		int redCount = 0;
		foreach (string s in player.inventory)  // Now disable them all in one go.
		{      
			if (s.Contains ("red sphere")) {
				redCount++;
			}
			if (s.Contains ("green sphere")) {
				greenCount++;
			}
		} 
		if (greenCount == 1 && redCount == 1) {
			light.SetActive (true);
		}
	}
}
