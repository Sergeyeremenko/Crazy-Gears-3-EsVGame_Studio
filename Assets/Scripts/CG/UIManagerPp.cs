﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManagerPp : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
    }
    public void Back()
    {
        SceneManager.LoadScene(1);
    }
}