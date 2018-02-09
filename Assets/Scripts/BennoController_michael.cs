
using UnityEngine;

using System.Collections;

public class BennoController_michael : MonoBehaviour {

    public float speed = 10, torque = 0;
	Rigidbody2D rigidbody;

	private bool canGrab = false;
	private bool holding = false;

    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
		if (Input.GetKeyDown(KeyCode.D)){
			if (holding) {
				transform.DetachChildren();
			}
		}
        Move(Input.GetAxisRaw("Horizontal"));
    }

    void Move(float horizontalInput)
    {
		if (horizontalInput != 0) {
			Debug.Log (horizontalInput);
			rigidbody.AddTorque (horizontalInput * torque);
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		canGrab = true;
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