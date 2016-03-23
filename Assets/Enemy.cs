using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    Collision2D collider;
	// Use this for initialization
	void Start () {
        collider = GetComponent<Collision2D>();
        
	}
	
	// Update is called once per frame
	void Update () {
        


	}


    void OnCollisionEnter2D(Collision2D other) {
        //end the game
        if (other.collider.tag == "Player") {
            //end game
            Debug.Log("FUCK");


 
        }





    }


}
