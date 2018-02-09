
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BennoController_Tre : MonoBehaviour {

  public float speed;
  private bool canGrab;
  private bool holding;

  void Update() {
    transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * speed * Time.deltaTime;
    if (Input.GetKeyDown(KeyCode.D)){
        if (holding) {
            transform.DetachChildren();
        }
    }
  }

  void Start()
    {
        canGrab = false;
        holding = false;
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