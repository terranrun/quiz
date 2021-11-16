using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseV : MonoBehaviour
{
    bool isPaused = false;
    public UnityEngine.Video.VideoPlayer videoPlayer;

    public void pauseGame()
    {
        
        if(isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
            videoPlayer.Play();

        }
        else
        {
            videoPlayer.Pause();
            Time.timeScale = 0;
            isPaused = true;
        }
    }
}
