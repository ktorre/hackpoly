﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chopping : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Food")
            Destroy(other);
    }
}