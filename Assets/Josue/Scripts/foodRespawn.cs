using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodRespawn : MonoBehaviour {
    private Vector3 respawnLocation = new Vector3 (-.55f, 3.113f, 1.593f);

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnTriggerExit(Collider other)
    {
        GameObject.Instantiate(other.gameObject, respawnLocation, new Quaternion(0, 0, 0, 0));
    }
}
