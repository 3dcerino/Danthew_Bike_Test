using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public AudioSource sfxPlayer;
    public AudioClip successSFX;
    


    public void CorrectSound()
    {
        sfxPlayer.PlayOneShot(successSFX);
    }

}
