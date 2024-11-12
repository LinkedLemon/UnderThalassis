using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField] private bool isSfx = false;
    private void Update()
    {
        AudioManager manager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        AudioSource audioPlayer = GetComponent<AudioSource>();

        if (isSfx == false)
        {
            audioPlayer.volume = manager.musicVolumeLevel;
        }
        else
        {
            audioPlayer.volume = manager.sfxVolumeLevel;
        }
    }
}
