using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stove1 : MonoBehaviour
{

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

        if (other.tag == "pan")
        {
            //call verifypot.cs
            other.GetComponent<verifypot>().touchstove = true;
        }


    }
}
