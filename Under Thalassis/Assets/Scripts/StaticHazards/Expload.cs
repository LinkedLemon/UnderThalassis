using UnityEngine;

public class Expload : MonoBehaviour
{
    [SerializeField] private CircleCollider2D exploadCollider;
    [SerializeField] private CircleCollider2D hitboxCollider;
    private float deathTime = 2.0f;

    private void Start()
    {
        exploadCollider.enabled = false;
        hitboxCollider.enabled = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        exploadCollider.enabled = true;
        Destroy(gameObject, deathTime);
    }
}

