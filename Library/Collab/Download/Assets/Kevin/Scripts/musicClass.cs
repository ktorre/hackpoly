using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicClass : MonoBehaviour {
    float initVolume = .25f;
    float fadeSpeed = .5f;
    AudioSource music;


    public void fadeIn ( string track ) {
    }
	// Use this for initialization
	void Start () {
        music = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
