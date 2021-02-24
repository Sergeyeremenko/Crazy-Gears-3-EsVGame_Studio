using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManagerINST : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
    }
    public void Menu()
    {
        SceneManager.LoadScene(4);
    }
    public void Level_1()
    {
        SceneManager.LoadScene(6);
    }
}