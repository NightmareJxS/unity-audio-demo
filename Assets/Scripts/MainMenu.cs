using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public AudioSource audio;

    public void PlayButton()
    {
        audio.Play();
    }

    public void StopSFX()
    {
        audio.Stop();
    }
}
