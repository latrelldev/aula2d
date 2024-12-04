using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource audioSource2;

    // Method to play the sound
    public void PlaySound()
    {
       
            audioSource.Play();
        
    }

    public void PlayMusic()
    {

        audioSource2.Play();

    }
}
