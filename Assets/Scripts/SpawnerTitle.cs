using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SpawnerTitle : MonoBehaviour {

    public GameObject benno;
    public GameObject iben;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnBennoCoroutine());
        StartCoroutine(SpawnIbenCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            SceneManager.LoadScene("BrookeScene");
        }
    }

    IEnumerator SpawnBennoCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(.12f);
            Instantiate(benno, new Vector3(Random.Range(-5, 10), 6, 0), Random.rotation);
        }
    }

    IEnumerator SpawnIbenCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(.1f);
            Instantiate(iben, new Vector3(Random.Range(-5, 10), 6, 0), Random.rotation);
        }
    }
}
