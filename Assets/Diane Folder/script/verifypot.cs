using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verifypot : MonoBehaviour
{

    public string Tag_to_verify = "choppedFood";
    public int count = 0;
    public float time = 2.0f;
    public GameObject flames;
    public Vector3 potPosition;
    public float height = .5f;
    public bool touchstove = false;

    bool starttimer= false;
    //public bool touchstove = false;

    // Use this for initialization
    void Start()
    {
        // Instantiate an object to the right of the current object

    }


    // Update is called once per frame
    void Update()
    {
        touchstove = true;
        print(time);
        if (touchstove == true && starttimer == true)
        {
            time -= Time.deltaTime;
            {
                if (time <= 0)
                {
                    //flames start 
                    Vector3 potPos = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
                    Instantiate(flames, new Vector3(potPos.x, potPos.y + height, potPos.z), transform.rotation);

                    starttimer = false;
                    print(time);
                }
                else if (count == 3)
                {
                    starttimer = false;
                }
            }
        }

    }
    void OnTriggerEnter(Collider other)
    {
            if (other.tag == Tag_to_verify && count < 3)
            {
                Destroy(other.gameObject);
                count++;
                time += 10;
                starttimer = true; 
            }
            
    }
}