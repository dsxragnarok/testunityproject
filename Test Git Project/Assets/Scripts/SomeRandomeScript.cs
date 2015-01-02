using UnityEngine;
using System.Collections;

public class SomeRandomeScript : MonoBehaviour {

	private int aNumber = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		aNumber += 1;

		if (aNumber % 10 == 0) {
			Debug.Log("Ya dude we got 10");
		}

	}

}
