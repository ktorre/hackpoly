using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepScore : MonoBehaviour {
    private static string scoreTag = "score";
    private int score;
    public GameObject txt;


	// Use this for initialization
	void Start () {
        score = 0;
        txt.GetComponent<UnityEngine.UI.Text>().text = score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        if ( Input.GetKeyDown( KeyCode.C ) ) { score += 25; }
        txt.GetComponent<UnityEngine.UI.Text>().text = score.ToString();
	}

    public void addToScore( int amount )
    {
        score += amount;
    }
}
