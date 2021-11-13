using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSpawn : MonoBehaviour
{
    public GameObject player;
    PlayerMovement playerMovementObject;
    public GameObject spawnPoint;
    void Start()
    {
        spawnPoint = GameObject.FindGameObjectWithTag("SpawnPoint");
        Instantiate(player, spawnPoint.transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
