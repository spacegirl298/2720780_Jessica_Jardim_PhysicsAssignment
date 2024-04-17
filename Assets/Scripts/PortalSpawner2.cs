using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSpawner2 : MonoBehaviour
{
    public GameObject teleporter2;
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
        Instantiate(teleporter2, transform.position, transform.rotation);

        if (StopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
