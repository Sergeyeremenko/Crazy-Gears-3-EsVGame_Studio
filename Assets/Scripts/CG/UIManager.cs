using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
    }
    public void NewGame()
    {
        SceneManager.LoadScene(4);
    }
    public void Level()
    {
        SceneManager.LoadScene(4);
    }
    public void Settings()
    {
        SceneManager.LoadScene(2);
    }
    public void Privacypolicy()
    {
        SceneManager.LoadScene(3);
    }
    public void Quit()
    {
        Application.Quit(); 
    }
}
