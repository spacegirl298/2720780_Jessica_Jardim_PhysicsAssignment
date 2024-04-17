using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public int playerScore;
    public int AIScore;
    public Text PlayerScoreText;
    public Text AIScoreText;

    public bool scored_P; //player
    public bool scored_AI; //AI

    public GameObject WINNER;
    public GameObject LOSER;

    public GameObject player;
    public GameObject puck;
    public GameObject opponent;

    public PuckMovement puckMoveScript;

    
    

    [SerializeField]
    public PuckTrigger puckOnTrig;

    [SerializeField]
    public PuckTrigger puckonTrig_Start;

    public int oneGoal;

 
  
  
   


    private void Start()
    {
        
        
        WINNER.SetActive(false);
        LOSER.SetActive(false);

        playerScore = 0;
        AIScore = 0;
        PlayerScoreText.text = playerScore.ToString();
        AIScoreText.text = AIScore.ToString();
    }

    public void Update()
    {
        
        scored_P = puckMoveScript.Playergoal;
        scored_AI = puckMoveScript.AIgoal;

        if(scored_P && oneGoal ==1 ) 
        {
          
            addPlayerScore();
                
        }
        if( scored_AI && oneGoal ==1 ) 
        {
            
            addPlayerScore();
        }

        if (playerScore == 5)
        {
          
            WINNER.SetActive(true);
            player.SetActive(false);
            opponent.SetActive(false);
            puck.SetActive(false);
            

        }

        if (AIScore == 5)
        {
            
            LOSER.SetActive(true);
            player.SetActive(false);
            opponent.SetActive(false);
            puck.SetActive(false);
            
        }
    }
    public void addPlayerScore()
    {
        //starting positions
        if (scored_P)
        {
        
            puckMoveScript.Playergoal = false;
            playerScore+= 1;
            PlayerScoreText.text = playerScore.ToString();
            oneGoal = 0;

            
            
        }

        if(scored_AI)
        {
            
            puckMoveScript.AIgoal = false;

            AIScore += 1;
            AIScoreText.text = AIScore.ToString();
            oneGoal = 0;
        }
    }

    public void minusPlayerScore()
    {
        if(playerScore>0)
        {
            playerScore = playerScore - 1;
            PlayerScoreText.text = playerScore.ToString("0");
            return;

        }
    }
    public void minusAIScore()
    {
        if (AIScore > 0)
        {
            AIScore= AIScore - 1;
            AIScoreText.text = AIScore.ToString("0");
            return;

        }
    }
    }

