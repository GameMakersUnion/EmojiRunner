using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {
    public Rigidbody2D rgbd;
    public int jumpForce;
    int timesJumped = 0;
    LevelManager lm;
	// Use this for initialization
	void Start () {
        rgbd = GetComponent<Rigidbody2D>();
        lm = GameObject.Find("LevelManager").GetComponent<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (timesJumped < 2)
            {
                rgbd.AddForce(transform.up * jumpForce);
                timesJumped++;
            }
        }
        rgbd.AddForce(-Vector2.left * 2.5f);
        
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.tag == "Ground")
        {
            timesJumped = 0;
        }
        if(other.collider.tag == "Collectable")
        {
            lm.incrementScore();
            
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Collectable")
        {
            rgbd.AddForce(-Vector2.left * 5.0f, ForceMode2D.Impulse);
            Destroy(other.gameObject);
        }
        if(other.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
