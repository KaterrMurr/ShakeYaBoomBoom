using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public AudioSource music;
    
    public void PauseGame()
    {
        Time.timeScale = 1 - Time.timeScale;
        if (Time.timeScale == 0)
        {
            music.Pause();
        }
    }

    public void ResumeGameWithMusic()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            music.Play();
        }
    }

    public void ResumeGame()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }

}
