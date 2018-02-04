using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateFood : MonoBehaviour {
    private string Pot;
    GameObject food;
    GameObject plate;

	// Use this for initialization
	void Start () {
        transform.GetChild(1).gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "pot")
            transform.GetChild(1).gameObject.SetActive(true);
    }
}
