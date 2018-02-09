
using UnityEngine;

using System.Collections;

public class BennoController_michael : MonoBehaviour {

    public float speed = 10, torque = 0, jumpSpeed = 0.1f;
	Rigidbody2D rigidbody;
	GameObject heldObject;
	Vector3 hammerOffset;

	private bool canGrab = false;
	private bool holding = false;

    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
		if (Input.GetKeyDown(KeyCode.Space)){
			if (holding) {
				//transform.DetachChildren();
				//torque /= 2;
			}
		}
		if (holding) {
			heldObject.transform.position = gameObject.transform.position + hammerOffset;
		}
        Move(Input.GetAxisRaw("Horizontal"));
    }
    void Move(float horizontalInput)
    {
		if (horizontalInput != 0) {
			rigidbody.AddTorque (horizontalInput * torque);
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.CompareTag("grabbable"))
			canGrab = true;
	}

	void OnCollisionStay2D(Collision2D coll) {
		if (coll.gameObject.CompareTag("grabbable")) {
			if (Input.GetKeyDown(KeyCode.Space)){
				if (canGrab) {
					heldObject = coll.gameObject;
					hammerOffset = gameObject.transform.position - heldObject.transform.position;
					heldObject.GetComponent<BoxCollider2D> ().isTrigger = true;
					heldObject.transform.position = gameObject.transform.position + hammerOffset;
					holding = true;
					canGrab = false;
					//torque *= 3;
					//rigidbody.centerOfMass = new Vector2(0f, 0f);
				}
			}
		}
	}

}