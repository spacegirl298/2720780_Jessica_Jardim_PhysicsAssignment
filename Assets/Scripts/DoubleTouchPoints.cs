using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoubleTouchPoints : MonoBehaviour
{
    public GameManager GameManager;
    public int PlayerTouches;
    public int AiTouches;
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            PlayerTouches++;
            AiTouches = 0;

            if (PlayerTouches >1)
            {
                
                GameManager.minusPlayerScore();
                PlayerTouches = 0;
                AiTouches = 0;
            }
        }
        else if (collision.transform.tag == "AI")
        {
            AiTouches++;
            PlayerTouches = 0;
            if (AiTouches >1)
            {
                GameManager.minusAIScore();
                AiTouches = 0;
                PlayerTouches = 0;
            }
        }
       
    }
}
