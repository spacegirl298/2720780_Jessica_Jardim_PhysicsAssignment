using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 5f;

    [SerializeField] Text countdownText;
    public string SceneToLoad;

    private void Start()
    {
        currentTime = startingTime;
    }
    private void Update()
    {
        currentTime -= 1 * Time.deltaTime; 
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene(SceneToLoad);
        }


    }
}
