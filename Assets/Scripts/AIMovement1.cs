using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement1 : MonoBehaviour
{
    Rigidbody2D rb;

    public Transform target;
    [SerializeField]
    Transform referenceTarget;

    [SerializeField]
    Transform goal;

    private float speed = 40;

    [SerializeField]
    public PuckTrigger puckOnTrig;

    [SerializeField]
    public PuckTrigger puckonTrig_Start;

    public bool ballPasses;
    Vector3 direction;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = null;
        ballPasses = false;
        ballPasses = puckonTrig_Start.ballPasses;

    }
    void Update()
    {
        if(puckonTrig_Start.gameObject.activeInHierarchy == false)
        {
            puckOnTrig.gameObject.SetActive(true);
        }
        
        ballPasses = puckOnTrig.ballPasses;

        if (ballPasses == true)
        {
            target = referenceTarget;
        }
        else
        {
            target = null;
        }


        direction = target.position - transform.position;
    }
    private void FixedUpdate()
    {

        if (target != null)
        {

            direction.z = 0f;

            rb.AddForce(direction.normalized * speed);

        }
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        Vector3 dirToGoal = goal.transform.position - target.transform.position;

        if (other.gameObject.CompareTag("puck"))
        {
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(dirToGoal.normalized *20, ForceMode2D.Impulse);
            rb.AddForce(-dirToGoal.normalized * 3);
        }
    }


}
