using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class JerBenno : MonoBehaviour {

    public float speed;
    public GameObject explosionPrefab;

    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * speed * Time.deltaTime;

        if (Input.GetKey("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Rocket"))
        {
            other.gameObject.transform.SetParent(gameObject.transform);
            other.gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1, 0);

        }

        if(other.gameObject.CompareTag("hat"))
        {
            other.gameObject.transform.SetParent(gameObject.transform);
            other.gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1, 0);

        }

        if (other.gameObject.CompareTag("cam"))
        {
            Destroy(other.gameObject);
            Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 20, -10);

        }

        if(other.gameObject.CompareTag("bomb"))
        {
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            gameObject.transform.position = new Vector3(1000, 0, 0);
            Destroy(other.gameObject);

        }
    }
}
