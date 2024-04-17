using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Unity.VisualScripting;
using UnityEngine;

public class PuckMovement : MonoBehaviour
{
    public Transform PucksStartingPos;
   // public Transform PlayersStartingPos;
    //public Transform AIStartingPos;
    public bool AIgoal;
    public bool Playergoal;
    Rigidbody2D rb;

   
    public GameManager gameManagerS;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        AIgoal = false;
        Playergoal = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
         gameManagerS.oneGoal = 1;
            if (other.tag == "AIGoal")
            {
         
          transform.position = PucksStartingPos.position;
            rb.velocity = new Vector2 (0, 0);
            AIgoal = true;

            }
            else if (other.tag == "PlayerGoal")
            {
           transform.position = PucksStartingPos.position;
            rb.velocity = new Vector2(0, 0);
            Playergoal = true;
            }
        }

}
