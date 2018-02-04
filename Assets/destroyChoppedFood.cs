using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stove : MonoBehaviour
{

    public string pan;
    public bool touchstove = false;
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

        if (other.tag == pan)
        {
            //call verifypot.cs
            other.GetComponent<verifypot>().touchstove = true;
        }


    }
}