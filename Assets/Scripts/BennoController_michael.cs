
using UnityEngine;

using System.Collections;

public class BennoController : MonoBehaviour {

    public float speed = 10, jumpVelocity = 10;
    Transform myTrans;
    Rigidbody2D myBody;

    void Start()
    {
        //  myBody = this.rigidbody2D;//Unity 4.6-
        myBody = this.GetComponent<Rigidbody2D>();//Unity 5+
        myTrans = this.transform;
    }

    void FixedUpdate()
    {

        Move(Input.GetAxisRaw("Horizontal"));
        if (Input.GetButtonDown("Jump"))
            Jump();
    }

    void Move(float horizonalInput)
    {

  void Update() {
		Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * speed * Time.deltaTime;
		if (movement.x != 0)
			Debug.Log (movement.x);
		rigidbody = gameObject.GetComponent<Rigidbody2D> ();
		rigidbody.AddTorque (torque);
	}

    public void Jump()
    {
        myBody.velocity += jumpVelocity * Vector2.up;
    }

}