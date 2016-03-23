using UnityEngine;
using System.Collections;

public class GroundSpawner : MonoBehaviour {
    public float speed;
    public float timer;

    public GameObject ground;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(timer <= 0.0f)
        {
            Instantiate(ground, transform.position, transform.rotation);
            timer = Random.Range(0.75f, 1.0f);
        }
        timer -= Time.deltaTime;
	}
}
