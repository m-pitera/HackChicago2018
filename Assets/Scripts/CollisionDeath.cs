using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDeath : MonoBehaviour {

    Transform playerLocation;
    DeathReset dr;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision other){
        if (other.gameObject.tag == "bad"){
            dr.respawn(playerLocation);
        }
    }
}
