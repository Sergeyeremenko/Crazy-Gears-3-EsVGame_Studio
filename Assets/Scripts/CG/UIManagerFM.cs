using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManagerFM : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
    }
    public void Menu()
    {
        SceneManager.LoadScene(1);
    }
    public void Next()
    {
        SceneManager.LoadScene(4);
    }
    public void Settings()
    {
        SceneManager.LoadScene(2);
    }
}
