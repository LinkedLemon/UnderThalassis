using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public float musicVolumeLevel;
    public float sfxVolumeLevel;

    public void ChangeMusicVolume(float volume)
    {
        musicVolumeLevel = volume;
    }
    public void ChangeSfxVolume(float volume)
    {
        sfxVolumeLevel = volume;
    }
}
