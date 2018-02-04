using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object2 : MonoBehaviour {


    public GameObject water;
    public GameObject obj1;
    public Shader obj1Material;
    public GameObject obj2;
    public Shader obj2Material;
    public string tagz;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == tagz)
        {
            if (other.gameObject == obj1)
            {
                water.gameObject.GetComponent<Renderer>().materials[0].shader = obj1Material;
            }
            else
            {
                water.gameObject.GetComponent<Renderer>().materials[0].shader = obj2Material;
            }
        }


    }
}
