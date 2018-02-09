
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class BrookeBennoController : MonoBehaviour {

  	public float speed;
	private bool canGrab;
	private bool holding;
	public bool isCowOnGoal;
//	private SpriteRenderer sprite;

  	void Update() {
		System.Random random = new System.Random ();
		float amount = (float)random.Next (40)*0.1f;
		transform.position += (new Vector3(Input.GetAxis("Horizontal")*amount, Input.GetAxis("Vertical")*amount, 0) * speed * Time.deltaTime);
        //		if (Input.GetKeyDown(KeyCode.D)){
        //			if (holding) {
        //				transform.DetachChildren();
        //			}
        //		}
        if (Input.GetKey("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

  	void Start()
    {
		canGrab = false;
		holding = false;
		isCowOnGoal = false;
//		sprite = GetComponent<SpriteRenderer> ();
    }

	void OnCollisionEnter2D(Collision2D other){
		canGrab = true;

	}

	void OnTriggerStay2D(Collider2D other) {
		if (other.tag == "collidable") {
//			while(other.gameObject.transform.position.x > -5) {
				other.gameObject.transform.position -= (new Vector3(0.1f, 0, 0) * speed * Time.deltaTime);
//			other.gameObject.transform.position = Vector3.MoveTowards(other.gameObject.transform.position, target.position, step);
//			}
			if (other.transform.position.x < 0) {
				Debug.Log ("end of game");
				other.transform.GetChild (0).GetComponent<SpriteRenderer> ().sortingOrder = 10;
				GameManager.instance.LoadNextSceneAfterSeconds (5f, "mikeScene");

			}
		}
	}

	void OnCollisionStay2D(Collision2D coll) {
		if (coll.gameObject.CompareTag("grabbable")) {
			if (Input.GetKeyDown(KeyCode.Space)){
				if (canGrab) {
					coll.gameObject.transform.SetParent(gameObject.transform);
					holding = true;
					canGrab = false;


				}
			}
		}
			
	}
}
