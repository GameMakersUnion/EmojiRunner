using UnityEngine;
using System.Collections;

public class Recyclable : MonoBehaviour {

    private BoxCollider2D coll;

	// Use this for initialization
	void Start () {
        coll = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Recycle")
            Destroy(gameObject);
    }
}
