﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManagerML : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
    }
    void Update()
    {
    }
    public void Back()
    {
        SceneManager.LoadScene(1);
    }
    public void Level1()
    {
        SceneManager.LoadScene(17);
    }
    public void Level2()
    {
        SceneManager.LoadScene(7);
    }
    public void Level3()
    {
        SceneManager.LoadScene(8);
    }
    public void Level4()
    {
        SceneManager.LoadScene(9);
    }
    public void Level5()
    {
        SceneManager.LoadScene(10);
    }
    public void Level6()
    {
        SceneManager.LoadScene(11);
    }
    public void Level7()
    {
        SceneManager.LoadScene(12);
    }
    public void Level8()
    {
        SceneManager.LoadScene(13);
    }
    public void Level9()
    {
        SceneManager.LoadScene(14);
    }
    public void Level10()
    {
        SceneManager.LoadScene(15);
    }
    public void Level11()
    {
        SceneManager.LoadScene(16);
    }
    public void CBBB()
    {
        SceneManager.LoadScene(19);
    }
}
