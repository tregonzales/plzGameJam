
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BennoController : MonoBehaviour {

  public float speed;

  void Update() {
    transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * speed * Time.deltaTime;
  }

  void Start()
    {
        
    }
}
