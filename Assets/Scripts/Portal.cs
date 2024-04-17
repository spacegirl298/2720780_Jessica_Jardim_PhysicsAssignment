using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public PortalSpawner Spawner1;
    public Transform PortalExit;
    public Transform PortalStart;
    public Transform NewSpawnPoint;
    //public GameObject PortalDestroy;
   // public GameObject DestroyStartPortal;

    private float SpawnAgain= 20f;
    private void Start()
    {
        //DestroyStartPortal.SetActive(false);
        //PortalDestroy.SetActive(false);
    }

    private void Update()
    {
        if (SpawnAgain > Spawner1.spawnTime)
        {
            transform.position = NewSpawnPoint.position;
        }
       
      //  Destroy(PortalDestroy, 15f);
      // Destroy(DestroyStartPortal, 15f);
      
       
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PortalEntrance")
        {

            transform.position = PortalExit.position ;
        }


    }
}
