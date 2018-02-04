using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class despawn : MonoBehaviour
{
    private static int scoreWorth = 25;

    public string Tag_to_destroy;
    // Use this for initialization
    void Start()
    {

    }
	

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == Tag_to_destroy)
        {
            //GameObject.Destroy((GameObject)other.gameObject);
            Destroy(other.gameObject, 3);
            this.GetComponent<keepScore>().addToScore(scoreWorth);
        }


    }
}