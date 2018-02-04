using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectParsing : MonoBehaviour {


    public GameObject water;
    public GameObject obj1;
    public Material obj1Material;
    public GameObject obj2;
    public Material obj2Material;
    public GameObject tagz;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider other)
    {
        if (other == tagz)
        {
            if(other.gameObject == obj1)
            {
                water.GetComponent<Renderer>().material = obj2Material;
            }
            else
            {
                water.GetComponent<Renderer>().material = obj2Material;
            }
        }


    }



}
