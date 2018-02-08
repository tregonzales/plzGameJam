using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JerBenno : MonoBehaviour {

    public float speed;

    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * speed * Time.deltaTime;
    }

    void Start()
    {

    }
}
