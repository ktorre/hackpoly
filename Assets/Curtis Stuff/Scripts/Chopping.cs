using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chopping : MonoBehaviour {

    public string Destroyer;
    public int HitPoints;
    public Vector3 transformLocal;
    public GameObject Replacements;
    public Vector3 scale;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {

        if (other.tag == Destroyer)
        {

            print(HitPoints);
            if (HitPoints > 1)
            {
                HitPoints--;
            }
            else
            {
                GameObject thing;
                thing = GameObject.Instantiate(Replacements, transformLocal, new Quaternion(0, 0, 0, 0));
                thing.transform.localScale = scale;
                Destroy(this.gameObject);
                    
            }

        }

           
    }
}