using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verifypot : MonoBehaviour
{

    public string Tag_to_verify;
    public int count = 0;
    public float time = 0.0f;
    public GameObject flames;
    public Vector3 potPosition;
    public float height = .5f;

    bool starttimer= false;

    // Use this for initialization
    void Start()
    {
        // Instantiate an object to the right of the current object
        Vector3 potPos = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        Instantiate(flames, new Vector3( potPos.x, potPos.y + height, potPos.z ), transform.rotation );
    }


    // Update is called once per frame
    void Update()
    {
        if (starttimer = true)
        {
            time -= Time.deltaTime;
            {
                if (time < 0)
                {
                    //flames start 
                    starttimer = false;
                }
            }
        }


    }
    void OnTriggerEnter(Collider other)
    {

            if (other.tag == Tag_to_verify && count <3)
            {
                Destroy(other.gameObject);
                count++;
                time += 10;
            starttimer = true;
            }
    }
}