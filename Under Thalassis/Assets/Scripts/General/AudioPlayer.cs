using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField] private bool isSfx = false;
    private AudioManager manager;
    private void Update()
    {
        if (GameObject.Find("AudioManager"))
        {
            GameObject objectManager = GameObject.Find("AudioManager");
            if (objectManager.TryGetComponent<AudioManager>(out AudioManager audioManager))
            {
                manager = audioManager;
            }
        }
        AudioSource audioPlayer = GetComponent<AudioSource>();

        if(manager != null)
        {
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
}
