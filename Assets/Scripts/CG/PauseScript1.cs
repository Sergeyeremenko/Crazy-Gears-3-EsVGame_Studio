using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class PauseScript1 : MonoBehaviour
{
    [SerializeField]
    private GameObject panelPause;
    [SerializeField]
    private GameObject player;
    private AudioSource Audio3;
    void Start()
    {
        Time.timeScale = 1;
        Audio3 = GetComponent<AudioSource>();
    }
    bool isPaused = false;
    public void pauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            panelPause.SetActive(false);
            isPaused = false;
            if (Audio3.mute)
                Audio3.mute = false;
        }
        else
        {
            Time.timeScale = 0;
            panelPause.SetActive(true);
            isPaused = true;
            Audio3.mute = true;
        }
    }
}