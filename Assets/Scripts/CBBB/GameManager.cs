using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int lives;
    public int score;
    public Text livesText;
    public Text scoreText;
    public Text highScoreText;
    public InputField highScoreInput;
    public bool gameOver;
    public GameObject gameOverPanel;
    public GameObject loadLevelPanel;
    public int numberOfBricks;
    public Transform[] levels;
    public int currentLevelIndex = 0;
    
    void Start()
    {
        livesText.text = "Lives: " + lives;
        scoreText.text = "Score: " + score;
        numberOfBricks = GameObject.FindGameObjectsWithTag ("Brick").Length;
    }
    void Update()
    {
        
    }
    public void UpdateLives(int changeInLives)
    {
        lives += changeInLives;
        if (lives <= 0)
        {
            lives = 0;
            GameOver ();
        }
        livesText.text = "Lives: " + lives;
    }
    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }
    public void UpdateNumberOfBricks()
    {
        numberOfBricks--;
        if(numberOfBricks <= 0)
        {
            if (currentLevelIndex >= levels.Length - 1)
            {
                GameOver();
            }
            else
            {
                loadLevelPanel.SetActive (true);
                loadLevelPanel.GetComponentInChildren<Text>().text = "Level " + (currentLevelIndex + 2); 
                gameOver = true;
                Invoke ("LoadLevel", 3f);
            }
        }
    }
    void LoadLevel()
    {
        currentLevelIndex++;
        Instantiate(levels[currentLevelIndex], Vector2.zero, Quaternion.identity);
        numberOfBricks = GameObject.FindGameObjectsWithTag("Brick").Length;
        gameOver = false;
        loadLevelPanel.SetActive (false);
    }
    void GameOver()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
        int highScore = PlayerPrefs.GetInt("Highscore");
        if (score > highScore)
        {
            PlayerPrefs.SetInt("Highscore", score);
            highScoreText.text = "New High Score!" + "\n" + "Enter Your Name Below.";
            highScoreInput.gameObject.SetActive (true);
        }
        else
        {
            highScoreText.text = PlayerPrefs.GetString ("HIGSCORENAME") + "'s " + " High Score was " + highScore + "\n" + "Can you beat it?";
        }
    }
    public void NewHighScore()
    {
        string highScoreName = highScoreInput.text;
        PlayerPrefs.SetString("HIGSCORENAME", highScoreName);
        highScoreInput.gameObject.SetActive(false);
        highScoreText.text = "Congratulations " + highScoreName + "\n" + "You New High Score is " + score;
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(20);
        Debug.Log("Перезапуск Сцены!!!");
    }
    public void Menu()
    {
        SceneManager.LoadScene(19);
        Debug.Log("Преход в меню");
    }
}
