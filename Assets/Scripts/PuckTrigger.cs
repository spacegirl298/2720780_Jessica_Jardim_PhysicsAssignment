using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckTrigger : MonoBehaviour
{
    public bool ballPasses;

    void Start()
    {
        ballPasses = true;
    }

    

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("puck") && ballPasses == false)
        {
            ballPasses = true;

        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (this.gameObject.name == "TriggerAI_Start")
        {
            this.gameObject.GetComponent<PuckTrigger>().gameObject.SetActive(false);

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("puck") && ballPasses == true)
        {
            ballPasses = false; //doesn't follow
        }
    }


}

