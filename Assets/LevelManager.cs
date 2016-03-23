using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
    public int score;
	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void incrementScore()
    {
        score++;
    }
}
