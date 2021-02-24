using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManage3 : MonoBehaviour
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
        SceneManager.LoadScene(1);
    }
    public void Settings()
    {
    SceneManager.LoadScene(2);
    }
}
