using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateFood : MonoBehaviour
{
    private string Pot;
    GameObject food;
    GameObject plate;


    // Use this for initialization
    void Start()
    {
        transform.GetChild(1).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "pot.full")
        {
            transform.GetChild(1).gameObject.SetActive(true);
            this.tag = "cookedFood";
            other.tag = "pot.empty;";
        }
    }
}
