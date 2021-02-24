using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager6l : MonoBehaviour
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
    public void Menu()
    {
        SceneManager.LoadScene(4);
    }
}