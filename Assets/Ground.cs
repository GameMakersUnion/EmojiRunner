using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {
    private Rigidbody2D rb;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.1f;
        rb.AddForce(Vector2.left*40.0f, ForceMode2D.Impulse);
        rb.rotation = Random.Range(0.0f,45.0f); ;
    }
	
	// Update is called once per frame
	void Update () {
        if (rb != null) { 
            rb.AddForce(Vector2.left * 5.0f);
        }
    }
}
