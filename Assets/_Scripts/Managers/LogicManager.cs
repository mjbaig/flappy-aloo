using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour {
    
    public int playerScore = 0;

    public Text scoreText;

    public GameObject gameOverCanvas;

    public bool IsGameOver { get; set; }= false;

    public void Start()
    {
        gameOverCanvas.SetActive(false);
    }

    [ContextMenu("Add Score")] //Allows you to call the method while in game using the hamburger menu on the script object
    public void addScore()
    {
        if (!IsGameOver)
        {
            playerScore += 1;
            scoreText.text = playerScore.ToString();
            Debug.Log($"Score {playerScore}"); 
        }
        
    }

    public void Update()
    {
        if (IsGameOver)
        {
            gameOverCanvas.SetActive(true);
        }
    }

    public void RestartGame()
    {
        IsGameOver = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
