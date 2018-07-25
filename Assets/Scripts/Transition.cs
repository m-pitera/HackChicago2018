using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour {

    public GameObject scene1;
    public GameObject scene2;
    public GameObject scene3;
    public GameObject transition1;
    public GameObject transition2;
    public GameObject transition3;
    public Transform player;
    public Transform spawn;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "scene1Done"){
            transition1.SetActive(false);
            transition2.SetActive(true);
            scene1.SetActive(false);
            scene2.SetActive(true);
            player.position = spawn.position;
        }

        if (other.gameObject.tag == "scene2Done"){
            transition2.SetActive(false);
            transition3.SetActive(true);
            scene2.SetActive(false);
            scene3.SetActive(true);
            player.position = spawn.position;
        }

        if (other.gameObject.tag == "scene3Done"){
            Debug.Log("s3Collide");
            transition3.SetActive(false);
            transition1.SetActive(true);
            scene3.SetActive(false);
            scene1.SetActive(true);
            player.position = spawn.position;
        }
    }
}
