
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BennoController_Mike : MonoBehaviour {

  public float speed;
	private Rigidbody2D rigidbody;
	public float torque = 0.1f;

  void Update() {
		Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * speed * Time.deltaTime;
		if (movement.x != 0)
			Debug.Log (movement.x);
		rigidbody = gameObject.GetComponent<Rigidbody2D> ();
		rigidbody.AddTorque (torque);
  }

  void Start()
    {
        
    }
}
