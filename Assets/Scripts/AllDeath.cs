using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllDeath : MonoBehaviour {

    public Transform spawn;
    public Transform playerLocation;
    public int minimumHeight;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (playerLocation.position.y <= minimumHeight)
        {
            respawn();
        }
    }

    public void respawn()
    {
        Debug.Log("DEATH POGGERS");
        playerLocation.position = spawn.position;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("collision, POGGERS");
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "bad")
        {
            respawn();
        }
    }
}
