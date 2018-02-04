using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn2 : MonoBehaviour {

    public Vector3 transformLocal;
    public GameObject Replacements;
    public Vector3 scale;
    public int HitPoints;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void HIT()
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

    void OnDestroy()
    {
    }
}
