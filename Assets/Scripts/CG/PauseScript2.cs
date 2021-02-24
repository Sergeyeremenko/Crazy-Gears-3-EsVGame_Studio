using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PauseScript2 : MonoBehaviour
{
    [SerializeField]
    private GameObject panelPause;
    [SerializeField]
    private GameObject player;
    private AudioSource Audio4;
    void Start()
    {
        Time.timeScale = 1;
        Audio4 = GetComponent<AudioSource>();
    }
    bool isPaused = false;
    public void pauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            panelPause.SetActive(false);
            isPaused = false;
            if (Audio4.mute)
                Audio4.mute = false;
        }
        else
        {
            Time.timeScale = 0;
            panelPause.SetActive(true);
            isPaused = true;
            Audio4.mute = true;
        }
    }
}
