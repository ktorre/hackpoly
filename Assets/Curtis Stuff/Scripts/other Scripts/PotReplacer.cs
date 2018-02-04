using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotReplacer : MonoBehaviour {
    public string Destroyer;
    public Vector3 transformLocal;
    public GameObject Replacements;
    public Vector3 scale;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnCollisionEnter(Collision crash)
    {
        if ((crash.gameObject.tag == "pot.empty" ) || (crash.gameObject.tag == "pot.full")){
            //this.transform=transformLocal;

        }
    }
}
