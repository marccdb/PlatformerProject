using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameSession : MonoBehaviour
{

    [SerializeField] int playerLives = 3;
    [SerializeField] int score = 0;
    [SerializeField] TextMeshProUGUI livesText;
    [SerializeField] TextMeshProUGUI scoreText;


    private void Awake()
    {
        if(FindObjectsOfType<GameSession>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    
    
    
    void Start()
    {

        livesText.text = playerLives.ToString();
        scoreText.text = score.ToString();

    }


    public void AddToScore(int points)
    {
        score += points;
        scoreText.text = score.ToString();
    }


    public void ProcessPlayerDeath()
    {

        if(playerLives > 1)
        {
            TakeLife();
        }
        else
        {
            ResetGameSession();
        }

    }

    private void TakeLife()
    {

        playerLives--;
        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        livesText.text = playerLives.ToString();

    }

    private void ResetGameSession()
    {

        SceneManager.LoadScene(0);
        Destroy(gameObject);

    }

}
