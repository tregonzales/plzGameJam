using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakerController : MonoBehaviour {

	public float offset = 1f;
	public float amplitude = 1f;
	public float frequency = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.position.x, amplitude * Mathf.Sin (frequency * Time.time) - 1f, 0);
	}
}
