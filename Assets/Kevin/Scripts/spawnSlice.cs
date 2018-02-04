using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSlice : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Q))
            GameObject.Instantiate(this);
	}
}
