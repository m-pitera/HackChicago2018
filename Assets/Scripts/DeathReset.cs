using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathReset : MonoBehaviour
{

    public Transform spawn;

    public void respawn(Transform playerLocation)
    {
        Debug.Log("repawn");
        playerLocation = spawn;
    }
}