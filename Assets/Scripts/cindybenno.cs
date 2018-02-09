using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cindybenno : MonoBehaviour {
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

        Vector2 moveVel = myBody.velocity;
        moveVel.x = horizonalInput * speed;
        myBody.velocity = moveVel;
    }

    public void Jump()
    {
        myBody.velocity += jumpVelocity * Vector2.up;
    }

}