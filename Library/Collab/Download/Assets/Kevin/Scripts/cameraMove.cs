using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour {
    public float speed = 2.0f;

	// Use this for initialization
	void Start () {
        //transform.rotation = Quaternion.identity;
	}

    // Update is called once per frame
    void LateUpdate () {
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        else if (Input.GetKey(KeyCode.RightArrow))
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        else if (Input.GetKey(KeyCode.UpArrow))
            transform.position = transform.position + (transform.forward * speed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.DownArrow) )
            transform.position = transform.position - (transform.forward * speed * Time.deltaTime);

	}   
}
