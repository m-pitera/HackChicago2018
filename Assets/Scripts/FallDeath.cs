using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDeath : MonoBehaviour {

    public Transform playerLocation;
    public int minimumHeight;

    // Use this for initialization
    void Start () {
        //DeathReset dr;
    }

// Update is called once per frame
    void Update () {
        var dr = new DeathReset();

		if (playerLocation.position.y <= minimumHeight){
            dr.respawn(playerLocation);
        }
	}
}
