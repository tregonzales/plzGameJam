using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualSpeakerController : MonoBehaviour {
	public WallController wallcon;
	public WallController blockcon;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("grabbable")) {
			wallcon.Open ();
			blockcon.Open ();
			Destroy (gameObject);
		}
	}
}
