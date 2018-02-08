
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BennoController_Tre : MonoBehaviour {

  public float speed;
  private bool canGrab;

  void Update() {
    transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * speed * Time.deltaTime;
  }

  void Start()
    {
        canGrab = false;
    }

    void OnCollisionEnter2D(Collision2D other){
        canGrab = true;
        other.gameObject.transform.SetParent(gameObject.transform);
        Debug.Log("enter");
  }

    void OnCollisionStay2D(Collision2D coll) {
        Debug.Log("stay");
        if (Input.GetKeyDown(KeyCode.Space)){
            if (canGrab) {
                coll.gameObject.transform.SetParent(gameObject.transform);
            }
        }
        
    }
}