﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class igaguriGenerator : MonoBehaviour {

    public GameObject igaguriPrefab;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject igakuri =
                 Instantiate(igaguriPrefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            igaguriPrefab.GetComponent<IgaguriController>().Shoot(
                worldDir.normalized * 2000);
           
        }
	}
}
