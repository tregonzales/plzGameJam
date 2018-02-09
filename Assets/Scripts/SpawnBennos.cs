﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SpawnBennos : MonoBehaviour {

    public GameObject benno;

    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnBennoCoroutine());
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey("q"))
        {
            Application.Quit();
        }
    }

    IEnumerator SpawnBennoCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(.5f);
            Instantiate(benno, new Vector3(Random.Range(-5, 10), 6, 0), Quaternion.identity);
        }
    }
}
