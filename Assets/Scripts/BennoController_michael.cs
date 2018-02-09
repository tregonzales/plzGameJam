
using UnityEngine;

using System.Collections;

public class BennoController_michael : MonoBehaviour {

    public float speed = 10, torque = 0;
	Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

        Move(Input.GetAxisRaw("Horizontal"));
    }

    void Move(float horizontalInput)
    {
		if (horizontalInput != 0) {
			Debug.Log (horizontalInput);
			rigidbody.AddTorque (horizontalInput * torque);
		}
	}


}