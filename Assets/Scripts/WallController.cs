using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour {
	private bool opening = false;
	public float speed = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (opening) {
			transform.position += Vector3.up * speed;
		}
	}

	public void Open(){
		opening = true;
	}
}
