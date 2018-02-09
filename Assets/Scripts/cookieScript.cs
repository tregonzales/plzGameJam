using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookieScript : MonoBehaviour {

	AudioSource yeaBoi;
	// Use this for initialization
	void Start () {
		yeaBoi = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.CompareTag("yeaBoi")){
			Destroy(other.gameObject);
			yeaBoi.Stop();
			Destroy(gameObject);
			GameObject.Find("benno").GetComponent<AudioSource>().Play();
			GameManager.instance.LoadSceneAfterSeconds(3f, "cindyscene");
		}
	}
}
