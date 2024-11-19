using UnityEngine;

public class Bubble : MonoBehaviour
{
    [SerializeField] private ParticleSystem bubblePartical;
    [SerializeField] private AudioSource bubbleSfx;

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
        ParticleSystem _bubbleInstance = Instantiate(bubblePartical, transform.position, Quaternion.identity);
        bubbleSfx.Play();
    }
}
