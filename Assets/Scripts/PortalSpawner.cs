using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSpawner : MonoBehaviour
{
    public GameObject teleporter1;
    public bool StopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    public void SpawnObject()
    {
        Instantiate(teleporter1, transform.position, transform.rotation);

        if (StopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
