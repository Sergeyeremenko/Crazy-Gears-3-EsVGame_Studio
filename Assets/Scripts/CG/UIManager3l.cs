using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager3 : MonoBehaviour
{
    void Start()
    {
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
    public void Level1()
    {
        SceneManager.LoadScene(1);
    }
    public void Level2()
    {
        SceneManager.LoadScene(2);
    }
    public void Level3()
    {
        SceneManager.LoadScene(6);
    }
    public void Level4()
    {
        SceneManager.LoadScene(8);
    }
    public void Level5()
    {
        SceneManager.LoadScene(9);
    }
}
