
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BennoController_Tre : MonoBehaviour {

  public float speed;
  Rigidbody2D myBody; 
  public float jumpVel;
  private bool canGrab;
  private bool holding;

  void Update() {
    transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0) * speed * Time.deltaTime;
    if (Input.GetKeyDown(KeyCode.UpArrow)){
        myBody.velocity += jumpVel * Vector2.up;
    }
    if (Input.GetKeyDown(KeyCode.D)){
        if (holding) {
            transform.Find("cookie").transform.parent = null;
        }
    }

    if (Input.GetKeyDown(KeyCode.R)){
        GameManager.instance.RestartTheGameAfterSeconds(.5);
    }
  }

  void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        canGrab = false;
        holding = false;
    }

    void OnCollisionEnter2D(Collision2D other){
        canGrab = true;
  }

    void OnCollisionStay2D(Collision2D coll) {
        if (coll.gameObject.CompareTag("cookie")) {
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