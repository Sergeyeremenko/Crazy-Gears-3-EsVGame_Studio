using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PauseScript6 : MonoBehaviour
{
    [SerializeField]
    private GameObject panelPause;
    [SerializeField]
    private GameObject player;
    private AudioSource Audio2;
    void Start()
    {
        Time.timeScale = 1;
        Audio2 = GetComponent<AudioSource>();
    }
    bool isPaused = false;
    public void pauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            panelPause.SetActive(false);
            isPaused = false;
            if (Audio2.mute)
                Audio2.mute = false;
        }
        else
        {
            Time.timeScale = 0;
            panelPause.SetActive(true);
            isPaused = true;
            Audio2.mute = true;
        }
    }
}