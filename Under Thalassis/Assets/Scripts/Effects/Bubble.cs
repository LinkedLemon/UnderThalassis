using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    [SerializeField] private ParticleSystem BubblePartical;
    [SerializeField] private AudioSource bubbleSfx;
    private ParticleSystem BubbleInstance;

    private int timer = 500;
    private void Update()
    {
        if (timer > 0)
        {
            timer--; 
        }
        else
        {
            SpawnParticales();
            timer = Random.Range(700, 1500);
        }
    }


    private void SpawnParticales()
    {
        BubbleInstance = Instantiate(BubblePartical, transform.position, Quaternion.identity);
        bubbleSfx.Play();
    }
}
