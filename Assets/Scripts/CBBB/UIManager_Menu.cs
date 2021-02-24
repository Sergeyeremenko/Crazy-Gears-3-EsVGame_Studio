using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager_Menu : MonoBehaviour
{
    public Text highscoreText;

    void Start()
    {
        if (PlayerPrefs.GetString ("HIGSCORENAME") != "")
        { 
            highscoreText.text = "High Score Set by " + PlayerPrefs.GetString ("HIGSCORENAME") + " " + PlayerPrefs.GetInt ("Highscore"); 
        }
    }
    void Update()
    {
        
    }
    public void Game()
    {
        SceneManager.LoadScene(20);
        Debug.Log("Преход на игру");
    }
    public void Quit()
    {
        SceneManager.LoadScene(4);
        Debug.Log("Выход!");
    }
    //public void Game1()
    //{
    //    SceneManager.LoadScene(20);
    //    Debug.Log("Преход в меню");
    //}
}
