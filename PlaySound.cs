using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip Click;

    public void PlayClip()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(Click); 
    }
}
